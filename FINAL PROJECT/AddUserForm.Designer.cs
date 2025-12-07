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
            // 
            // lblFullname
            // 
            lblFullname.AutoSize = true;
            lblFullname.ForeColor = Color.White;
            lblFullname.Location = new Point(25, 20);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(73, 19);
            lblFullname.TabIndex = 0;
            lblFullname.Text = "Full Name:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(25, 55);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(74, 19);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(25, 90);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 19);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(120, 18);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(270, 25);
            txtFullname.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(120, 52);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(270, 25);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(120, 87);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(270, 25);
            txtPassword.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(120, 130);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 36);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(250, 130);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 36);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // AddUserForm
            // 
            BackColor = Color.FromArgb(0, 0, 0);
            ClientSize = new Size(420, 200);
            Controls.Add(lblFullname);
            Controls.Add(txtFullname);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Font = new Font("Segoe UI", 10F);
            Name = "AddUserForm";
            Text = "Add User";
            Load += AddUserForm_Load;
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
