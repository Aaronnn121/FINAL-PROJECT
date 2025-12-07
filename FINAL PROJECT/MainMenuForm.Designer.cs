// MainMenuForm.Designer.cs
namespace FINAL_PROJECT
{
    partial class MainMenuForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblWelcome;
        private Button btnAddUser;
        private Button btnListUsers;
        private Button btnTransfer;
        private Button btnLogout;
        private Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblWelcome = new Label();
            btnAddUser = new Button();
            btnListUsers = new Button();
            btnTransfer = new Button();
            btnLogout = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(24, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(94, 15);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, [User]";
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(24, 59);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(220, 53);
            btnAddUser.TabIndex = 1;
            btnAddUser.Text = "Add New User";
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnListUsers
            // 
            btnListUsers.Location = new Point(24, 119);
            btnListUsers.Name = "btnListUsers";
            btnListUsers.Size = new Size(220, 53);
            btnListUsers.TabIndex = 2;
            btnListUsers.Text = "List Users";
            btnListUsers.Click += btnListUsers_Click;
            // 
            // btnTransfer
            // 
            btnTransfer.Location = new Point(24, 179);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(220, 53);
            btnTransfer.TabIndex = 3;
            btnTransfer.Text = "Transfer Money";
            btnTransfer.Click += btnTransfer_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(24, 239);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(100, 47);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.Click += btnLogout_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(144, 239);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 47);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.Click += btnExit_Click;
            // 
            // MainMenuForm
            // 
            ClientSize = new Size(277, 320);
            Controls.Add(lblWelcome);
            Controls.Add(btnAddUser);
            Controls.Add(btnListUsers);
            Controls.Add(btnTransfer);
            Controls.Add(btnLogout);
            Controls.Add(btnExit);
            Name = "MainMenuForm";
            Text = "Main Menu";
            Load += MainMenuForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
