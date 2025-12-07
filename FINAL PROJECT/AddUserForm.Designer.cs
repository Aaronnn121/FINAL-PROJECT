namespace FINAL_PROJECT
{
    partial class AddUserForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblFullname = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtFullname = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // lblFullname
            lblFullname.AutoSize = true;
            lblFullname.Location = new Point(25, 20);
            lblFullname.Name = "lblFullname";
            lblFullname.Text = "Full Name:";
            // txtFullname
            txtFullname.Location = new Point(120, 18);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(240, 23);
            // lblUsername
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(25, 55);
            lblUsername.Name = "lblUsername";
            lblUsername.Text = "Username:";
            // txtUsername
            txtUsername.Location = new Point(120, 52);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(240, 23);
            // lblPassword
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(25, 90);
            lblPassword.Name = "lblPassword";
            lblPassword.Text = "Password:";
            // txtPassword
            txtPassword.Location = new Point(120, 87);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(240, 23);
            txtPassword.PasswordChar = '*';
            // btnSave
            btnSave.Location = new Point(120, 130);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 30);
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // btnCancel
            btnCancel.Location = new Point(270, 130);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 30);
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // AddUserForm
            ClientSize = new Size(400, 190);
            Controls.Add(lblFullname);
            Controls.Add(txtFullname);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "AddUserForm";
            Text = "Add User";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
