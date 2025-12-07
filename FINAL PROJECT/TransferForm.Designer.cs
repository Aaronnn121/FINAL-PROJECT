namespace FINAL_PROJECT
{
    partial class TransferForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            cbReceiver = new ComboBox();
            btnTransfer = new Button();
            txtAmount = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // cbReceiver
            // 
            cbReceiver.FormattingEnabled = true;
            cbReceiver.Location = new Point(175, 100);
            cbReceiver.Name = "cbReceiver";
            cbReceiver.Size = new Size(184, 23);
            cbReceiver.TabIndex = 0;
            // 
            // btnTransfer
            // 
            btnTransfer.Location = new Point(259, 197);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(100, 46);
            btnTransfer.TabIndex = 2;
            btnTransfer.Text = "Transfer";
            btnTransfer.UseVisualStyleBackColor = true;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(175, 150);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(184, 23);
            txtAmount.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 104);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Receiver";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 153);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Amount";
            // 
            // TransferForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 350);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbReceiver);
            Controls.Add(txtAmount);
            Controls.Add(btnTransfer);
            Name = "TransferForm";
            Text = "Transfer Funds";
            Load += TransferForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbReceiver;
        private TextBox txtAmount;
        private Button btnTransfer;
        private Label label1;
        private Label label2;
    }
}
