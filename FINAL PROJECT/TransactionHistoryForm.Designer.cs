namespace FINAL_PROJECT
{
    partial class TransactionHistoryForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgTransactions = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgTransactions).BeginInit();
            SuspendLayout();
            // 
            // dgTransactions
            // 
            dgTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTransactions.Location = new Point(30, 20);
            dgTransactions.Name = "dgTransactions";
            dgTransactions.Size = new Size(740, 380);
            dgTransactions.TabIndex = 0;
            // 
            // TransactionHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgTransactions);
            Name = "TransactionHistoryForm";
            Text = "Transaction History";
            Load += TransactionHistoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgTransactions).EndInit();
            ResumeLayout(false);
        }

        private DataGridView dgTransactions;
    }
}
