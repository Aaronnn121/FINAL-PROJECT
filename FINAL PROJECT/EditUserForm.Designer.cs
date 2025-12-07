namespace FINAL_PROJECT
{
    partial class EditUserForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtFullname;
        private TextBox txtUsername;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPassword;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnSave = new Button();
            btnCancel = new Button();
            txtFullname = new TextBox();
            txtUsername = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(122, 208);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 34);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(233, 208);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 34);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(122, 71);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(240, 25);
            txtFullname.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(122, 112);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(240, 25);
            txtUsername.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(52, 74);
            label1.Name = "label1";
            label1.Size = new Size(64, 19);
            label1.TabIndex = 3;
            label1.Text = "Fullname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(49, 115);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(53, 157);
            label3.Name = "label3";
            label3.Size = new Size(67, 19);
            label3.TabIndex = 0;
            label3.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(122, 154);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(240, 25);
            txtPassword.TabIndex = 1;
            // 
            // EditUserForm
            // 
            BackColor = Color.FromArgb(0, 0, 0);
            ClientSize = new Size(420, 320);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Controls.Add(txtFullname);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Font = new Font("Segoe UI", 10F);
            Name = "EditUserForm";
            Text = "Edit User";
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
