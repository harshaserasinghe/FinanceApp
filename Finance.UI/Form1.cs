using Finance.Core.DTOs;
using Finance.Core.Entities;
using Finance.Service;
using System;
using System.Windows.Forms;

namespace Finance.UI
{
    public partial class FinanceForm : Form
    {
        private ContactService contactService { get; }
        private TransactionService transactionService { get; }

        public FinanceForm()
        {
            InitializeComponent();
            contactService = new ContactService();
            transactionService = new TransactionService();
            FormInit();
        }

        private void FormInit()
        {
            cmbContact.DataSource = contactService.GetContacts();
            cmbContact.DisplayMember = nameof(ContactDTO.Name);
            cmbContact.ValueMember = nameof(ContactDTO.ContactId);

            cmbTranType.DataSource = Enum.GetValues(typeof(TranType));
            cmbTranTypeSearch.DataSource = Enum.GetValues(typeof(TranType));
            cmbRecTranFreq.DataSource = Enum.GetValues(typeof(Frequency));

            dgvTran.AutoGenerateColumns = false;
            dgvTran.AutoSize = true;
            AddTexBoxColumn(nameof(TransactionDTO.Name), "Name", true);
            AddComboBoxColumn(nameof(TransactionDTO.TranType), "Type", typeof(TranType), true);
            AddTexBoxColumn(nameof(TransactionDTO.TranDate), "Date", true);
            AddTexBoxColumn(nameof(TransactionDTO.Amount), "Amount", true);
            AddCheckBoxColumn(nameof(TransactionDTO.IsRecurring), "Recurring", true);
            AddTexBoxColumn(nameof(TransactionDTO.ContactName), "Contact", true);
            AddComboBoxColumn(nameof(CreateTransactionDTO.Frequency), "Occurrence", typeof(Frequency), true);
        }

        private void AddTexBoxColumn(string propName, string colName, bool isReadOnly)
        {
            var col = new DataGridViewTextBoxColumn();
            col.DataPropertyName = propName;
            col.Name = colName;
            col.ReadOnly = isReadOnly;
            dgvTran.Columns.Add(col);
        }

        private void AddComboBoxColumn(string prop, string colName, Type enumType, bool isReadOnly)
        {
            var col = new DataGridViewComboBoxColumn();
            col.DataSource = Enum.GetValues(enumType);
            col.DataPropertyName = prop;
            col.Name = colName;
            col.ReadOnly = isReadOnly;
            dgvTran.Columns.Add(col);
        }

        private void AddCheckBoxColumn(string prop, string colName, bool isReadOnly)
        {
            var col = new DataGridViewCheckBoxColumn();
            col.DataPropertyName = prop;
            col.Name = colName;
            col.ReadOnly = isReadOnly;
            dgvTran.Columns.Add(col);
        }

        private void AddTransaction(object sender, EventArgs e)
        {
            var CreateTranDTO = new CreateTransactionDTO
            {
                Name = txbTranName.Text,
                Description = txbTranDesc.Text,
                TranType = (TranType)Enum.Parse(typeof(TranType), cmbTranType.SelectedValue.ToString()),
                TranDate = dtpTranDate.Value,
                ContactId = Int32.Parse(cmbContact.SelectedValue.ToString()),
                Amount = Decimal.Parse(txbTranAmount.Text),
                IsRecurring = chbRecTran.Checked,
                Frequency = (Frequency)Enum.Parse(typeof(Frequency), cmbRecTranFreq.SelectedValue.ToString()),
            };

            transactionService.AddTransaction(CreateTranDTO);
        }

        private void SearchTransaction(object sender, EventArgs e)
        {
            var tranType = (TranType)Enum.Parse(typeof(TranType), cmbTranType.SelectedValue.ToString());
            var fromDate = dtpTranFromDate.Value;
            var toDate = dtpTranToDate.Value;

            dgvTran.DataBindings.Clear();
            var tranDTOs = transactionService.GetTransactionsByDate(tranType, fromDate, toDate);
            var bindingSource = new BindingSource(tranDTOs, null);
            dgvTran.DataSource = bindingSource;

        }

        private void SelectedRow(object sender, EventArgs e)
        {
            var value = dgvTran.SelectedRows;
        }
    }
}
