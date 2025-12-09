using System;
using System.Windows.Forms;

namespace FINAL_PROJECT
{
    public partial class MainMenuForm : Form
    {
        private User _currentUser;
        public bool IsLoggingOut { get; private set; }

        public MainMenuForm(User currentUser)
        {
            _currentUser = currentUser;
            InitializeComponent();
            Theme.ApplyToForm(this);
            lblWelcome.Text = $"Welcome, {_currentUser.Fullname}";
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            using (var f = new AddUserForm()) f.ShowDialog();
        }

        private void btnListUsers_Click(object sender, EventArgs e)
        {
            using (var f = new ListUsersForm()) f.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes) Application.Exit();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            using (var f = new TransferForm(_currentUser.Id))
            {
                f.ShowDialog();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                IsLoggingOut = true;
                this.Close();
            }
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
