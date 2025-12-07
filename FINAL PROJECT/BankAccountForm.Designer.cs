namespace FINAL_PROJECT
{
    partial class BankAccountForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblFullname;
        private Label lblFullnameValue;
        private Label lblBalance;
        private Label lblBalanceValue;
        private TextBox txtAmount;
        private Button btnDeposit;
        private Button btnWithdraw;
        private Button btnViewTransactions;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblFullname = new Label();
            this.lblFullnameValue = new Label();
            this.lblBalance = new Label();
            this.lblBalanceValue = new Label();
            this.txtAmount = new TextBox();
            this.btnDeposit = new Button();
            this.btnWithdraw = new Button();
            this.btnViewTransactions = new Button();

            this.SuspendLayout();
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Location = new System.Drawing.Point(25, 20);
            this.lblFullname.Text = "Full Name:";
            // 
            // lblFullnameValue
            // 
            this.lblFullnameValue.AutoSize = true;
            this.lblFullnameValue.Location = new System.Drawing.Point(120, 20);
            this.lblFullnameValue.Text = "---";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(25, 50);
            this.lblBalance.Text = "Balance:";
            // 
            // lblBalanceValue
            // 
            this.lblBalanceValue.AutoSize = true;
            this.lblBalanceValue.Location = new System.Drawing.Point(120, 50);
            this.lblBalanceValue.Text = "₱0.00";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(25, 90);
            this.txtAmount.Size = new System.Drawing.Size(180, 23);
            this.txtAmount.PlaceholderText = "Enter amount";
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(220, 90);
            this.btnDeposit.Size = new System.Drawing.Size(80, 23);
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(310, 90);
            this.btnWithdraw.Size = new System.Drawing.Size(80, 23);
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnViewTransactions
            // 
            this.btnViewTransactions.Location = new System.Drawing.Point(25, 125);
            this.btnViewTransactions.Size = new System.Drawing.Size(150, 28);
            this.btnViewTransactions.Text = "View Transactions";
            this.btnViewTransactions.Click += new System.EventHandler(this.btnViewTransactions_Click);
            // 
            // BankAccountForm
            // 
            this.ClientSize = new System.Drawing.Size(420, 170);
            this.Controls.Add(this.lblFullname);
            this.Controls.Add(this.lblFullnameValue);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblBalanceValue);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnViewTransactions);
            this.Name = "BankAccountForm";
            this.Text = "Bank Account";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
