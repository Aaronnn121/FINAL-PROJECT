using System;
using System.IO;
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
            LoadRememberedUsername();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Enter username and password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnLogin.Enabled = false;
            btnCancel.Enabled = false;
            var previousCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            User user = null;
            try
            {
                user = await Task.Run(() => userRepo.GetByUsername(username));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during login: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = previousCursor;
                btnLogin.Enabled = true;
                btnCancel.Enabled = true;
            }

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
                if (menu.IsLoggingOut)
                {
                    // Return to login form to allow re-login
                    txtPassword.Clear();
                    this.Show();
                    txtPassword.Focus();
                    return;
                }
            }

            // User didn't request logout -> close login (exit)
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Designer sets PasswordChar='*' by default; toggle to '\0' to show.
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }

        private void LoadRememberedUsername()
        {
            try
            {
                var dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FINAL-PROJECT");
                var path = Path.Combine(dir, "lastuser.txt");
                if (File.Exists(path))
                {
                    txtUsername.Text = File.ReadAllText(path);
                }
            }
            catch
            {
                // ignore read errors
            }
        }

        private void SaveLastUsername(string username)
        {
            try
            {
                var dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FINAL-PROJECT");
                Directory.CreateDirectory(dir);
                var path = Path.Combine(dir, "lastuser.txt");
                File.WriteAllText(path, username);
            }
            catch
            {
                // ignore write errors
            }
        }

        private void DeleteLastUsername()
        {
            try
            {
                var dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FINAL-PROJECT");
                var path = Path.Combine(dir, "lastuser.txt");
                if (File.Exists(path)) File.Delete(path);
            }
            catch
            {
                // ignore delete errors
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
