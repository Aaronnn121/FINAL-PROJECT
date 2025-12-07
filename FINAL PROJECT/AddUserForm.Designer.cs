namespace FINAL_PROJECT
{
    partial class AddUserForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblFullname;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtFullname;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnSave;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
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

            // Form
            this.ClientSize = new Size(420, 200);
            this.BackColor = Color.FromArgb(0, 0, 0);
            this.Font = new Font("Segoe UI", 10F);

            // lblFullname
            lblFullname.AutoSize = true;
            lblFullname.Location = new Point(25, 20);
            lblFullname.ForeColor = Color.White;
            lblFullname.Text = "Full Name:";

            // txtFullname
            txtFullname.Location = new Point(120, 18);
            txtFullname.Size = new Size(270, 23);
            StyleTextBox(txtFullname);

            // lblUsername
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(25, 55);
            lblUsername.ForeColor = Color.White;
            lblUsername.Text = "Username:";

            // txtUsername
            txtUsername.Location = new Point(120, 52);
            txtUsername.Size = new Size(270, 23);
            StyleTextBox(txtUsername);

            // lblPassword
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(25, 90);
            lblPassword.ForeColor = Color.White;
            lblPassword.Text = "Password:";

            // txtPassword
            txtPassword.Location = new Point(120, 87);
            txtPassword.Size = new Size(270, 23);
            txtPassword.PasswordChar = '*';
            StyleTextBox(txtPassword);

            // btnSave
            btnSave.Location = new Point(120, 130);
            btnSave.Size = new Size(100, 36);
            btnSave.Text = "Save";
            StylePrimaryButton(btnSave);
            btnSave.Click += btnSave_Click;

            // btnCancel
            btnCancel.Location = new Point(250, 130);
            btnCancel.Size = new Size(100, 36);
            btnCancel.Text = "Cancel";
            StyleSecondaryButton(btnCancel);
            btnCancel.Click += btnCancel_Click;

            // Add controls
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

        private void StyleTextBox(TextBox t)
        {
            t.BackColor = Color.FromArgb(17, 17, 17);
            t.ForeColor = Color.White;
            t.BorderStyle = BorderStyle.FixedSingle;
        }

        private void StylePrimaryButton(Button b)
        {
            b.BackColor = Color.FromArgb(0, 255, 117);
            b.ForeColor = Color.Black;
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        }

        private void StyleSecondaryButton(Button b)
        {
            b.BackColor = Color.FromArgb(17, 17, 17);
            b.ForeColor = Color.FromArgb(0, 255, 117);
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 117);
            b.FlatAppearance.BorderSize = 2;
            b.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        }
    }
}
