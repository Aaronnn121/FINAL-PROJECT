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
            lblFullname = new Label();
            lblFullnameValue = new Label();
            lblBalance = new Label();
            lblBalanceValue = new Label();
            txtAmount = new TextBox();
            btnDeposit = new Button();
            btnWithdraw = new Button();
            btnViewTransactions = new Button();
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
            // lblFullnameValue
            // 
            lblFullnameValue.AutoSize = true;
            lblFullnameValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFullnameValue.ForeColor = Color.FromArgb(0, 255, 117);
            lblFullnameValue.Location = new Point(140, 20);
            lblFullnameValue.Name = "lblFullnameValue";
            lblFullnameValue.Size = new Size(27, 20);
            lblFullnameValue.TabIndex = 1;
            lblFullnameValue.Text = "---";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.ForeColor = Color.White;
            lblBalance.Location = new Point(25, 50);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(58, 19);
            lblBalance.TabIndex = 2;
            lblBalance.Text = "Balance:";
            // 
            // lblBalanceValue
            // 
            lblBalanceValue.AutoSize = true;
            lblBalanceValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBalanceValue.ForeColor = Color.FromArgb(0, 255, 117);
            lblBalanceValue.Location = new Point(140, 50);
            lblBalanceValue.Name = "lblBalanceValue";
            lblBalanceValue.Size = new Size(62, 25);
            lblBalanceValue.TabIndex = 3;
            lblBalanceValue.Text = "₱0.00";
            // 
            // txtAmount
            // 
            txtAmount.BackColor = Color.FromArgb(17, 17, 17);
            txtAmount.BorderStyle = BorderStyle.FixedSingle;
            txtAmount.ForeColor = Color.White;
            txtAmount.Location = new Point(25, 90);
            txtAmount.Name = "txtAmount";
            txtAmount.PlaceholderText = "Enter amount";
            txtAmount.Size = new Size(220, 25);
            txtAmount.TabIndex = 4;
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(260, 88);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(90, 30);
            btnDeposit.TabIndex = 5;
            btnDeposit.Text = "Deposit";
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.BackColor = Color.FromArgb(0, 107, 56);
            btnWithdraw.FlatAppearance.BorderSize = 0;
            btnWithdraw.FlatStyle = FlatStyle.Flat;
            btnWithdraw.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnWithdraw.ForeColor = Color.White;
            btnWithdraw.Location = new Point(360, 88);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(90, 30);
            btnWithdraw.TabIndex = 6;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = false;
            // 
            // btnViewTransactions
            // 
            btnViewTransactions.Location = new Point(25, 130);
            btnViewTransactions.Name = "btnViewTransactions";
            btnViewTransactions.Size = new Size(180, 36);
            btnViewTransactions.TabIndex = 7;
            btnViewTransactions.Text = "View Transactions";
            btnViewTransactions.Click += btnViewTransactions_Click;
            // 
            // BankAccountForm
            // 
            BackColor = Color.FromArgb(0, 0, 0);
            ClientSize = new Size(480, 200);
            Controls.Add(lblFullname);
            Controls.Add(lblFullnameValue);
            Controls.Add(lblBalance);
            Controls.Add(lblBalanceValue);
            Controls.Add(txtAmount);
            Controls.Add(btnDeposit);
            Controls.Add(btnWithdraw);
            Controls.Add(btnViewTransactions);
            Font = new Font("Segoe UI", 10F);
            Name = "BankAccountForm";
            Text = "Bank Account";
            Load += BankAccountForm_Load;
            ResumeLayout(false);
            PerformLayout();
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
