namespace FINAL_PROJECT
{
    partial class TransactionHistoryForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgTransactions;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgTransactions = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgTransactions).BeginInit();
            SuspendLayout();

            // Form
            this.ClientSize = new Size(820, 480);
            this.BackColor = Color.FromArgb(0, 0, 0);
            this.Font = new Font("Segoe UI", 10F);

            // dgTransactions
            dgTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTransactions.Location = new Point(20, 20);
            dgTransactions.Name = "dgTransactions";
            dgTransactions.Size = new Size(780, 420);
            dgTransactions.TabIndex = 0;
            StyleDataGridView(dgTransactions);

            // Add
            Controls.Add(dgTransactions);
            Name = "TransactionHistoryForm";
            Text = "Transaction History";
            Load += TransactionHistoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgTransactions).EndInit();
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
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
