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
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnAddUser = new Button();
            btnListUsers = new Button();
            btnExit = new Button();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // btnAddUser
            // 
            btnAddUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAddUser.Location = new Point(60, 120);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(259, 40);
            btnAddUser.TabIndex = 1;
            btnAddUser.Text = "Add New User";
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnListUsers
            // 
            btnListUsers.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnListUsers.Location = new Point(60, 180);
            btnListUsers.Name = "btnListUsers";
            btnListUsers.Size = new Size(259, 40);
            btnListUsers.TabIndex = 2;
            btnListUsers.Text = "List Users";
            btnListUsers.Click += btnListUsers_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExit.Location = new Point(60, 240);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(259, 40);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.Click += btnExit_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(60, 41);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(259, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Bank System Menu";
            // 
            // MainMenuForm
            // 
            ClientSize = new Size(380, 330);
            Controls.Add(lblTitle);
            Controls.Add(btnAddUser);
            Controls.Add(btnListUsers);
            Controls.Add(btnExit);
            Name = "MainMenuForm";
            Text = "Main Menu";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
