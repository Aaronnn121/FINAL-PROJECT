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

            // Form
            this.ClientSize = new Size(480, 200);
            this.BackColor = Color.FromArgb(0, 0, 0);
            this.Font = new Font("Segoe UI", 10F);

            // lblFullname
            lblFullname.AutoSize = true;
            lblFullname.Location = new Point(25, 20);
            lblFullname.ForeColor = Color.White;
            lblFullname.Text = "Full Name:";

            // lblFullnameValue
            lblFullnameValue.AutoSize = true;
            lblFullnameValue.Location = new Point(140, 20);
            lblFullnameValue.ForeColor = Color.FromArgb(0, 255, 117);
            lblFullnameValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFullnameValue.Text = "---";

            // lblBalance
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(25, 50);
            lblBalance.ForeColor = Color.White;
            lblBalance.Text = "Balance:";

            // lblBalanceValue
            lblBalanceValue.AutoSize = true;
            lblBalanceValue.Location = new Point(140, 50);
            lblBalanceValue.ForeColor = Color.FromArgb(0, 255, 117);
            lblBalanceValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBalanceValue.Text = "₱0.00";

            // txtAmount
            txtAmount.Location = new Point(25, 90);
            txtAmount.Size = new Size(220, 25);
            txtAmount.PlaceholderText = "Enter amount";
            txtAmount.BackColor = Color.FromArgb(17, 17, 17);
            txtAmount.ForeColor = Color.White;
            txtAmount.BorderStyle = BorderStyle.FixedSingle;

            // btnDeposit
            btnDeposit.Location = new Point(260, 88);
            btnDeposit.Size = new Size(90, 30);
            btnDeposit.Text = "Deposit";
            StylePrimaryButton(btnDeposit);
            btnDeposit.Click += btnDeposit_Click;

            // btnWithdraw
            btnWithdraw.Location = new Point(360, 88);
            btnWithdraw.Size = new Size(90, 30);
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.BackColor = Color.FromArgb(0, 107, 56); // dark green
            btnWithdraw.ForeColor = Color.White;
            btnWithdraw.FlatStyle = FlatStyle.Flat;
            btnWithdraw.FlatAppearance.BorderSize = 0;
            btnWithdraw.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnWithdraw.Click += btnWithdraw_Click;

            // btnViewTransactions
            btnViewTransactions.Location = new Point(25, 130);
            btnViewTransactions.Size = new Size(180, 36);
            btnViewTransactions.Text = "View Transactions";
            StyleSecondaryButton(btnViewTransactions);
            btnViewTransactions.Click += btnViewTransactions_Click;

            // Add controls
            Controls.Add(lblFullname);
            Controls.Add(lblFullnameValue);
            Controls.Add(lblBalance);
            Controls.Add(lblBalanceValue);
            Controls.Add(txtAmount);
            Controls.Add(btnDeposit);
            Controls.Add(btnWithdraw);
            Controls.Add(btnViewTransactions);
            Name = "BankAccountForm";
            Text = "Bank Account";
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
