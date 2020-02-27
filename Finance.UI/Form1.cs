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
        public CreateTransactionDTO createTranDTO { get; }

        public FinanceForm()
        {
            contactService = new ContactService();
            createTranDTO = new CreateTransactionDTO();
            InitializeComponent();
            FormInit();
        }

        private void FormInit()
        {
            cmbContact.DataSource = contactService.GetContacts();
            cmbContact.DisplayMember = nameof(ContactDTO.Name);
            cmbContact.ValueMember = nameof(ContactDTO.ContactId);

            cmbTranType.DataSource = Enum.GetValues(typeof(TranType));
            cmbRecTranFreq.DataSource = Enum.GetValues(typeof(Frequency));

            cmbTranType.DataBindings.Add("Value", createTranDTO, nameof(CreateTransactionDTO.TranType));
            dtpTranDate.DataBindings.Add("Value", createTranDTO, nameof(CreateTransactionDTO.TranDate));
            cmbContact.DataBindings.Add("Value", createTranDTO, nameof(CreateTransactionDTO.ContactId));
            txbAmount.DataBindings.Add("Text", createTranDTO, nameof(CreateTransactionDTO.Amount));
            txbDesc.DataBindings.Add("Text", createTranDTO, nameof(CreateTransactionDTO.Name));
            chbRecurring.DataBindings.Add("CheckState", createTranDTO, nameof(CreateTransactionDTO.IsRecurring));
        }

        private void AddTransaction(object sender, EventArgs e)
        {

        }
    }
}
