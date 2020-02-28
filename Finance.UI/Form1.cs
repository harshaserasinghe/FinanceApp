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

        //public CreateTransactionDTO createTranDTO { get; }

        public FinanceForm()
        {
            InitializeComponent();
            contactService = new ContactService();
            transactionService = new TransactionService();
            FormInit();
            //createTranDTO = new CreateTransactionDTO();

        }

        private void FormInit()
        {
            cmbContact.DataSource = contactService.GetContacts();
            cmbContact.DisplayMember = nameof(ContactDTO.Name);
            cmbContact.ValueMember = nameof(ContactDTO.ContactId);

            cmbTranType.DataSource = Enum.GetValues(typeof(TranType));
            cmbRecTranFreq.DataSource = Enum.GetValues(typeof(Frequency));

            //cmbTranType.DataBindings.Add("SelectedValue", createTranDTO, nameof(CreateTransactionDTO.TranType));
            //dtpTranDate.DataBindings.Add("Value", createTranDTO, nameof(CreateTransactionDTO.TranDate));
            //cmbContact.DataBindings.Add("SelectedValue", createTranDTO, nameof(CreateTransactionDTO.ContactId));
            //txbAmount.DataBindings.Add("Text", createTranDTO, nameof(CreateTransactionDTO.Amount));
            //txbDesc.DataBindings.Add("Text", createTranDTO, nameof(CreateTransactionDTO.Name));
            //chbRecurring.DataBindings.Add("CheckState", createTranDTO, nameof(CreateTransactionDTO.IsRecurring));
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
    }
}
