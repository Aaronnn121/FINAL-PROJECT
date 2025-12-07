using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_PROJECT
{
    public partial class BankAccountForm : Form

    {
        private int _userId;
        private BankAccount account;

        private UserRepository userRepo = new UserRepository();
        private BankAccountRepository accRepo = new BankAccountRepository();
        private TransactionRepository txRepo = new TransactionRepository();

        public BankAccountForm(int userId)
        {
            InitializeComponent();
            Theme.ApplyToForm(this);
            _userId = userId;
            LoadAccount();
        }

        private void LoadAccount()
        {
            var user = userRepo.Get(_userId);
            lblFullnameValue.Text = user?.Fullname ?? "(Unknown)";

            account = accRepo.GetByUser(_userId);
            if (account == null)
            {
                accRepo.CreateAccountForUser(_userId);
                account = accRepo.GetByUser(_userId);
            }

            lblBalanceValue.Text = "₱" + account.Balance.ToString("N2");
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid positive amount.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            account.Balance += amount;
            accRepo.Update(account);

            txRepo.Add(new Transaction
            {
                UserId = _userId,
                AccountId = account.Id,
                Amount = amount,
                Type = "Deposit",
                CreatedAt = DateTime.UtcNow,
                Remarks = "Deposit via UI"
            });

            lblBalanceValue.Text = "₱" + account.Balance.ToString("N2");
            txtAmount.Clear();

            // print receipt
            ReceiptPrinter.PrintDepositReceipt(userRepo.Get(_userId), account, amount);

            MessageBox.Show("Deposit successful!", "Deposit", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid positive amount.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (account.Balance < amount)
            {
                MessageBox.Show("Insufficient funds!", "Withdraw", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            account.Balance -= amount;
            accRepo.Update(account);

            txRepo.Add(new Transaction
            {
                UserId = _userId,
                AccountId = account.Id,
                Amount = -amount,
                Type = "Withdraw",
                CreatedAt = DateTime.UtcNow,
                Remarks = "Withdraw via UI"
            });

            lblBalanceValue.Text = "₱" + account.Balance.ToString("N2");
            txtAmount.Clear();

            ReceiptPrinter.PrintWithdrawReceipt(userRepo.Get(_userId), account, amount);

            MessageBox.Show("Withdrawal successful!", "Withdraw", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void btnViewTransactions_Click(object sender, EventArgs e)
        {
            if (account == null)
            {
                MessageBox.Show("No account found.", "Transactions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var f = new TransactionHistoryForm(account.Id))
            {
                f.ShowDialog();
            }
        }

        private void BankAccountForm_Load(object sender, EventArgs e)
        {

        }
    }
}