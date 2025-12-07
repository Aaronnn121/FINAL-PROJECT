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
    public partial class LoginForm : Form
    {
        private UserRepository userRepo = new UserRepository();

        public LoginForm()
        {
            InitializeComponent();
            Theme.ApplyToForm(this);
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Enter username and password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = userRepo.GetByUsername(username);
            if (user == null || !AuthService.VerifyPassword(password, user.PasswordHash))
            {
                MessageBox.Show("Invalid credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Successful login: open MainMenu and show user's name
            this.Hide();
            using (var menu = new MainMenuForm(user))
            {
                menu.ShowDialog();
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
