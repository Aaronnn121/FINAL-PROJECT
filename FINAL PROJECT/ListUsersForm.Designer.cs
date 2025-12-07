namespace FINAL_PROJECT
{
    partial class ListUsersForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgViewUsers;
        private System.Windows.Forms.Button btnViewAccount;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnViewTransactions;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgViewUsers = new DataGridView();
            btnViewAccount = new Button();
            btnRefresh = new Button();
            btnViewTransactions = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgViewUsers).BeginInit();
            SuspendLayout();
            // 
            // dgViewUsers
            // 
            dgViewUsers.AllowUserToAddRows = false;
            dgViewUsers.AllowUserToDeleteRows = false;
            dgViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgViewUsers.Location = new System.Drawing.Point(25, 25);
            dgViewUsers.MultiSelect = false;
            dgViewUsers.Name = "dgViewUsers";
            dgViewUsers.ReadOnly = true;
            dgViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgViewUsers.Size = new System.Drawing.Size(760, 320);
            dgViewUsers.TabIndex = 2;
            // 
            // btnViewAccount
            // 
            btnViewAccount.Location = new System.Drawing.Point(25, 360);
            btnViewAccount.Name = "btnViewAccount";
            btnViewAccount.Size = new System.Drawing.Size(150, 35);
            btnViewAccount.TabIndex = 1;
            btnViewAccount.Text = "View Bank Account";
            btnViewAccount.UseVisualStyleBackColor = true;
            btnViewAccount.Click += btnViewAccount_Click;
            // 
            // btnViewTransactions
            // 
            btnViewTransactions.Location = new System.Drawing.Point(190, 360);
            btnViewTransactions.Name = "btnViewTransactions";
            btnViewTransactions.Size = new System.Drawing.Size(150, 35);
            btnViewTransactions.TabIndex = 4;
            btnViewTransactions.Text = "View Transactions";
            btnViewTransactions.Click += btnViewTransactions_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(360, 360);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(90, 35);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(460, 360);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(90, 35);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new System.Drawing.Point(675, 360);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(110, 35);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ListUsersForm
            // 
            this.ClientSize = new System.Drawing.Size(810, 410);
            this.Controls.Add(btnDelete);
            this.Controls.Add(btnEdit);
            this.Controls.Add(btnViewTransactions);
            this.Controls.Add(btnRefresh);
            this.Controls.Add(btnViewAccount);
            this.Controls.Add(dgViewUsers);
            this.Name = "ListUsersForm";
            this.Text = "List of Users";
            ((System.ComponentModel.ISupportInitialize)dgViewUsers).EndInit();
            ResumeLayout(false);
        }
    }
}
