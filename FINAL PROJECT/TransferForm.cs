using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_PROJECT
{
    public partial class TransferForm : Form
    {

        private int _sourceAccountId;

        private BankAccountRepository accRepo = new BankAccountRepository();
        private UserRepository userRepo = new UserRepository();
        private TransactionRepository txRepo = new TransactionRepository();

        public TransferForm(int sourceAccountId)
        {
            InitializeComponent();
            _sourceAccountId = sourceAccountId;
            LoadUsers();
            Theme.ApplyToForm(this);

        }


        private void LoadUsers()
        {
            // Get all users from DB
            var allUsers = userRepo.GetAll();

            // Get the source account
            var sourceAcc = accRepo.GetById(_sourceAccountId);

            // Remove the sender from the list (cannot transfer to own account)
            var users = allUsers.Where(u => u.Id != sourceAcc.UserId).ToList();

            // Fill ComboBox with USERNAMES
            cbReceiver.DataSource = users;
            cbReceiver.DisplayMember = "Username";   // ← show usernames
            cbReceiver.ValueMember = "Id";

        }

        private void TransferForm_Load(object sender, EventArgs e)
        {

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Enter a valid amount.");
                return;
            }

            var sourceAcc = accRepo.GetById(_sourceAccountId);
            if (sourceAcc == null)
            {
                MessageBox.Show("Source account not found.");
                return;
            }

            if (sourceAcc.Balance < amount)
            {
                MessageBox.Show("Insufficient funds.");
                return;
            }

            if (cbReceiver.SelectedItem == null)
            {
                MessageBox.Show("Select a receiver.");
                return;
            }

            var receiverUser = cbReceiver.SelectedItem as User;
            var receiverAcc = accRepo.GetByUser(receiverUser.Id);

            if (receiverAcc == null)
            {
                MessageBox.Show("Receiver does not have an account.");
                return;
            }

            // get sender user for a readable remark
            var senderUser = userRepo.Get(sourceAcc.UserId);

            // update accounts
            sourceAcc.Balance -= amount;
            receiverAcc.Balance += amount;

            accRepo.Update(sourceAcc);
            accRepo.Update(receiverAcc);

            // log transactions — use usernames in Remarks instead of raw account ids
            txRepo.Add(new Transaction
            {
                UserId = receiverUser.Id,
                AccountId = receiverAcc.Id,
                Amount = amount,
                Type = "Transfer In",
                CreatedAt = DateTime.UtcNow,
                Remarks = $"Received from {senderUser?.Username ?? "(Unknown)"} (Acc {sourceAcc.Id})"
            });

            txRepo.Add(new Transaction
            {
                UserId = sourceAcc.UserId,
                AccountId = sourceAcc.Id,
                Amount = -amount,
                Type = "Transfer Out",
                CreatedAt = DateTime.UtcNow,
                Remarks = $"Sent to {receiverUser.Username} (Acc {receiverAcc.Id})"
            });

            // print receipt
            ReceiptPrinter.PrintTransferReceipt(senderUser, receiverUser, sourceAcc, receiverAcc, amount);

            MessageBox.Show("Transfer successful!");
            this.Close();
        }
    }
}
