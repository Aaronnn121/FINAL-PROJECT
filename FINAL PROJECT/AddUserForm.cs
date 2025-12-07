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
    public partial class AddUserForm : Form
    {
        UserRepository userRepo = new UserRepository();
        BankAccountRepository accRepo = new BankAccountRepository();

        public AddUserForm()
        {
            InitializeComponent();
            Theme.ApplyToForm(this);
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            string fullname = txtFullname.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(fullname) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            var existing = userRepo.GetByUsername(username);
            if (existing != null)
            {
                MessageBox.Show("Username already exists. Pick another.");
                return;
            }

            User u = new User
            {
                Fullname = fullname,
                Username = username,
                PasswordHash = AuthService.HashPassword(password)
            };

            int newUserId = userRepo.Add(u);

            if (newUserId <= 0)
            {
                MessageBox.Show("Failed to add user.");
                return;
            }

            accRepo.CreateAccountForUser(newUserId);

            MessageBox.Show("User created successfully with a new bank account!");

            txtFullname.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
