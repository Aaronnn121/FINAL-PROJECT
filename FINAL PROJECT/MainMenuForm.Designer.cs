namespace FINAL_PROJECT
{
    partial class MainMenuForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnAddUser;
        private Button btnListUsers;
        private Button btnExit;
        private Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnAddUser = new Button();
            btnListUsers = new Button();
            btnExit = new Button();
            lblTitle = new Label();
            SuspendLayout();

            // Form
            this.ClientSize = new System.Drawing.Size(380, 330);
            this.BackColor = Color.FromArgb(0, 0, 0);
            this.Font = new Font("Segoe UI", 11F);

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 255, 117);
            lblTitle.Location = new Point(60, 41);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(259, 37);
            lblTitle.Text = "Bank System Menu";

            // btnAddUser
            btnAddUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAddUser.Location = new Point(60, 120);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(259, 40);
            btnAddUser.TabIndex = 1;
            btnAddUser.Text = "Add New User";
            StylePrimaryButton(btnAddUser);
            btnAddUser.Click += btnAddUser_Click;

            // btnListUsers
            btnListUsers.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnListUsers.Location = new Point(60, 180);
            btnListUsers.Name = "btnListUsers";
            btnListUsers.Size = new Size(259, 40);
            btnListUsers.TabIndex = 2;
            btnListUsers.Text = "List Users";
            StylePrimaryButton(btnListUsers);
            btnListUsers.Click += btnListUsers_Click;

            // btnExit
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExit.Location = new Point(60, 240);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(259, 40);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            StyleSecondaryButton(btnExit);
            btnExit.Click += btnExit_Click;

            // Add controls
            this.Controls.Add(lblTitle);
            this.Controls.Add(btnAddUser);
            this.Controls.Add(btnListUsers);
            this.Controls.Add(btnExit);
            this.Name = "MainMenuForm";
            this.Text = "Main Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        // Helper to style primary (green) buttons
        private void StylePrimaryButton(Button b)
        {
            b.BackColor = Color.FromArgb(0, 255, 117);
            b.ForeColor = Color.Black;
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
        }

        // Helper to style secondary (dark) buttons with green border
        private void StyleSecondaryButton(Button b)
        {
            b.BackColor = Color.FromArgb(17, 17, 17);
            b.ForeColor = Color.FromArgb(0, 255, 117);
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 117);
            b.FlatAppearance.BorderSize = 2;
        }
    }
}
