using System;
using System.Windows.Forms;

namespace FINAL_PROJECT
{
    public partial class TransactionHistoryForm : Form
    {
        private int _accountId;
        private TransactionRepository txRepo = new TransactionRepository();

        public TransactionHistoryForm(int accountId)
        {
            InitializeComponent();
            Theme.ApplyToForm(this);
            _accountId = accountId;
            LoadHistory();
        }

        private void LoadHistory()
        {
          var txs = txRepo.GetByAccount(_accountId);
            dgTransactions.DataSource = txs;
            if (dgTransactions.Columns.Contains("Amount"))
                dgTransactions.Columns["Amount"].DefaultCellStyle.Format = "N2";
            if (dgTransactions.Columns.Contains("CreatedAt"))
                dgTransactions.Columns["CreatedAt"].HeaderText = "Date";
        }

        private void TransactionHistoryForm_Load(object sender, EventArgs e)
        {
            // optional reload
            LoadHistory();
        }
    }
}
