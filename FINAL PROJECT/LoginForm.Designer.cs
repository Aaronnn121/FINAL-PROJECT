namespace FINAL_PROJECT
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblUsername = new Label();
            this.lblPassword = new Label();
            this.txtUsername = new TextBox();
            this.txtPassword = new TextBox();
            this.btnLogin = new Button();
            this.btnCancel = new Button();
            this.SuspendLayout();

            // FORM STYLING
            this.BackColor = Color.FromArgb(0, 0, 0); // Black background
            this.Font = new Font("Segoe UI", 10F);

            // lblUsername
            this.lblUsername.AutoSize = true;
            this.lblUsername.ForeColor = Color.White;   // White text
            this.lblUsername.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(20, 20);
            this.lblUsername.Text = "Username:";

            // txtUsername
            this.txtUsername.Location = new System.Drawing.Point(120, 17);
            this.txtUsername.Size = new System.Drawing.Size(220, 23);
            this.txtUsername.BackColor = Color.FromArgb(17, 17, 17);  // Dark textbox
            this.txtUsername.ForeColor = Color.White;
            this.txtUsername.BorderStyle = BorderStyle.FixedSingle;

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = Color.White;   // White text
            this.lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(20, 60);
            this.lblPassword.Text = "Password:";

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(120, 57);
            this.txtPassword.Size = new System.Drawing.Size(220, 23);
            this.txtPassword.BackColor = Color.FromArgb(17, 17, 17);
            this.txtPassword.ForeColor = Color.White;
            this.txtPassword.BorderStyle = BorderStyle.FixedSingle;
            this.txtPassword.PasswordChar = '*';

            // btnLogin
            this.btnLogin.Location = new System.Drawing.Point(120, 100);
            this.btnLogin.Size = new Size(90, 32);
            this.btnLogin.Text = "Login";

            // Modern Button Style (Green)
            this.btnLogin.BackColor = Color.FromArgb(0, 255, 117);
            this.btnLogin.ForeColor = Color.Black;
            this.btnLogin.FlatStyle = FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(250, 100);
            this.btnCancel.Size = new Size(90, 32);
            this.btnCancel.Text = "Cancel";

            // Cancel = inverted style
            this.btnCancel.BackColor = Color.FromArgb(17, 17, 17);
            this.btnCancel.ForeColor = Color.FromArgb(0, 255, 117);
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 117);
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // LoginForm
            this.ClientSize = new System.Drawing.Size(360, 150);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
