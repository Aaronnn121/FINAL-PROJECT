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

            // Form
            this.ClientSize = new Size(900, 500);
            this.BackColor = Color.FromArgb(0, 0, 0);
            this.Font = new Font("Segoe UI", 10F);

            // dgViewUsers
            dgViewUsers.AllowUserToAddRows = false;
            dgViewUsers.AllowUserToDeleteRows = false;
            dgViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgViewUsers.Location = new Point(25, 25);
            dgViewUsers.MultiSelect = false;
            dgViewUsers.Name = "dgViewUsers";
            dgViewUsers.ReadOnly = true;
            dgViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgViewUsers.Size = new Size(840, 360);
            dgViewUsers.TabIndex = 2;
            StyleDataGridView(dgViewUsers);

            // btnViewAccount
            btnViewAccount.Location = new Point(25, 400);
            btnViewAccount.Name = "btnViewAccount";
            btnViewAccount.Size = new Size(150, 35);
            btnViewAccount.TabIndex = 1;
            btnViewAccount.Text = "View Bank Account";
            StylePrimaryButton(btnViewAccount);
            btnViewAccount.Click += btnViewAccount_Click;

            // btnViewTransactions
            btnViewTransactions.Location = new Point(190, 400);
            btnViewTransactions.Name = "btnViewTransactions";
            btnViewTransactions.Size = new Size(150, 35);
            btnViewTransactions.TabIndex = 4;
            btnViewTransactions.Text = "View Transactions";
            StylePrimaryButton(btnViewTransactions);
            btnViewTransactions.Click += btnViewTransactions_Click;

            // btnEdit
            btnEdit.Location = new Point(360, 400);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(90, 35);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            StyleSecondaryButton(btnEdit);
            btnEdit.Click += btnEdit_Click;

            // btnDelete
            btnDelete.Location = new Point(460, 400);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 35);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            // Danger style: red border + dark bg
            btnDelete.BackColor = Color.FromArgb(17, 17, 17);
            btnDelete.ForeColor = Color.FromArgb(0, 255, 117);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(255, 68, 68);
            btnDelete.FlatAppearance.BorderSize = 2;
            btnDelete.Click += btnDelete_Click;

            // btnRefresh
            btnRefresh.Location = new Point(750, 400);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(110, 35);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            StylePrimaryButton(btnRefresh);
            btnRefresh.Click += btnRefresh_Click;

            // Add controls
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnViewTransactions);
            Controls.Add(btnRefresh);
            Controls.Add(btnViewAccount);
            Controls.Add(dgViewUsers);
            Name = "ListUsersForm";
            Text = "List of Users";
            ((System.ComponentModel.ISupportInitialize)dgViewUsers).EndInit();
            ResumeLayout(false);
        }

        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.FromArgb(0, 0, 0);
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 107, 56);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgv.RowHeadersVisible = false;
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(17, 17, 17);
            dgv.DefaultCellStyle.ForeColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(10, 10, 10);
            dgv.GridColor = Color.FromArgb(0, 255, 117);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 255, 117);
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void StylePrimaryButton(Button b)
        {
            b.BackColor = Color.FromArgb(0, 255, 117);
            b.ForeColor = Color.Black;
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        }

        private void StyleSecondaryButton(Button b)
        {
            b.BackColor = Color.FromArgb(17, 17, 17);
            b.ForeColor = Color.FromArgb(0, 255, 117);
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 117);
            b.FlatAppearance.BorderSize = 2;
            b.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        }
    }
}
