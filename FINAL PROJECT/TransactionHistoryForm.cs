using System;
using System.Linq;
using System.Globalization;
using System.Windows.Forms;

namespace FINAL_PROJECT
{
    public partial class TransactionHistoryForm : Form
    {
        private int _accountId;
        private TransactionRepository txRepo = new TransactionRepository();
        private UserRepository userRepo = new UserRepository();

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

            // Project transactions into a display model that includes username instead of numeric ids
            var display = txs.Select(t => new
            {
                Date = t.CreatedAt,
                Type = t.Type,
                Amount = t.Amount,
                Remarks = t.Remarks,
                Username = userRepo.Get(t.UserId)?.Username ?? "(Unknown)"
            }).ToList();

            dgTransactions.DataSource = display;

            if (dgTransactions.Columns.Contains("Amount"))
            {
                var col = dgTransactions.Columns["Amount"];
                col.DefaultCellStyle.Format = "C2"; // currency with 2 decimals
                col.DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-PH"); // ₱
            }

            if (dgTransactions.Columns.Contains("Date"))
                dgTransactions.Columns["Date"].HeaderText = "Date";
            if (dgTransactions.Columns.Contains("Username"))
                dgTransactions.Columns["Username"].HeaderText = "User";
        }

        private void TransactionHistoryForm_Load(object sender, EventArgs e)
        {
            // optional reload
            LoadHistory();
        }
    }
}
