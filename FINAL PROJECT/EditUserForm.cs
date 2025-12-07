using System;
using System.Windows.Forms;

namespace FINAL_PROJECT
{
    public partial class EditUserForm : Form
    {
        public User User { get; private set; }
        private UserRepository userRepo = new UserRepository();

        public EditUserForm(User user)
        {
            InitializeComponent();
            User = user;
            txtFullname.Text = User.Fullname;
            txtUsername.Text = User.Username;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fullname = txtFullname.Text.Trim();
            string username = txtUsername.Text.Trim();
            string newPassword = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(fullname) || string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Fullname and username are required.");
                return;
            }

            // Username uniqueness check
            if (!string.Equals(User.Username, username))
            {
                var existing = userRepo.GetByUsername(username);
                if (existing != null)
                {
                    MessageBox.Show("Username already exists.");
                    return;
                }
            }

            User.Fullname = fullname;
            User.Username = username;

            if (!string.IsNullOrEmpty(newPassword))
            {
                User.PasswordHash = AuthService.HashPassword(newPassword);
            }

            userRepo.Update(User);

            MessageBox.Show("User updated!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
