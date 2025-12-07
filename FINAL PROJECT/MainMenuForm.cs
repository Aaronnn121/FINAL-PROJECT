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
    public partial class MainMenuForm : Form
    {
        private User _currentUser;

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
            Application.Exit();

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
            using (var f = new TransferForm(_currentUser.Id))
            {
                f.ShowDialog();
            }
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
