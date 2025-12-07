using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FINAL_PROJECT
{
    public partial class ListUsersForm : Form
    {
        private UserRepository userRepo = new UserRepository();
        private BankAccountRepository accRepo = new BankAccountRepository();
        private TransactionRepository txRepo = new TransactionRepository();
        public ListUsersForm()
        {
            InitializeComponent();
            Theme.ApplyToForm(this);
            StartPosition = FormStartPosition.CenterParent;
            LoadUsers();
        }

        private void LoadUsers()
        {
            var users = userRepo.GetAll();
            dgViewUsers.DataSource = users;
            if (dgViewUsers.Columns.Contains("Id"))
                dgViewUsers.Columns["Id"].Visible = false;
            if (dgViewUsers.Columns.Contains("PasswordHash"))
                dgViewUsers.Columns["PasswordHash"].Visible = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnViewAccount_Click(object sender, EventArgs e)
        {
            if (dgViewUsers.CurrentRow == null) { MessageBox.Show("Please select a user first."); return; }
            var user = dgViewUsers.CurrentRow.DataBoundItem as User;
            if (user == null) return;
            using (var f = new BankAccountForm(user.Id)) f.ShowDialog();
            LoadUsers();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgViewUsers.CurrentRow == null) { MessageBox.Show("Select a user."); return; }
            var user = dgViewUsers.CurrentRow.DataBoundItem as User;
            if (user == null) return;

            using (var dlg = new EditUserForm(user))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    userRepo.Update(dlg.User);
                    LoadUsers();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgViewUsers.CurrentRow == null) { MessageBox.Show("Select a user."); return; }
            var user = dgViewUsers.CurrentRow.DataBoundItem as User;
            if (user == null) return;

            var r = MessageBox.Show($"Delete {user.Fullname}? This will remove account and transactions.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r != DialogResult.Yes) return;

            // delete transactions
            txRepo.DeleteByUser(user.Id);

            // delete account
            var acc = accRepo.GetByUser(user.Id);
            if (acc != null) accRepo.Delete(acc.Id);

            // delete user
            userRepo.Delete(user.Id);

            LoadUsers();
        }


        private void btnViewTransactions_Click(object sender, EventArgs e)
        {
            if (dgViewUsers.CurrentRow == null) { MessageBox.Show("Select a user."); return; }
            var user = dgViewUsers.CurrentRow.DataBoundItem as User;
            if (user == null) return;

            var acc = accRepo.GetByUser(user.Id);
            if (acc == null) { MessageBox.Show("No account for selected user."); return; }

            using (var f = new TransactionHistoryForm(acc.Id))
            {
                f.ShowDialog();
            }
        }

        private void ListUsersForm_Load(object sender, EventArgs e)
        {

        }
    }
}