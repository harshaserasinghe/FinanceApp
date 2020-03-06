using Finance.Core.DTOs;
using Finance.Core.Entities;
using Finance.Service;
using Finance.UI.Views;
using System;

namespace Finance.UI.Controllers
{
    public class TransactionController
    {
        private TransactionView view { get; set; }
        private ContactService contactService { get; }
        private TransactionService transactionService { get; }
        public TransactionController(TransactionView view)
        {
            this.view = view;
            this.view.SetController(this);
            contactService = new ContactService();
            transactionService = new TransactionService();
        }

        public void LoadView()
        {
            this.view.Contact.DataSource = contactService.GetContacts();
            this.view.Contact.DisplayMember = nameof(ContactDTO.Name);
            this.view.Contact.ValueMember = nameof(ContactDTO.ContactId);

            this.view.TranType.DataSource = Enum.GetValues(typeof(TranType));
            this.view.Frequency.DataSource = Enum.GetValues(typeof(Frequency));

            this.view.Show();
        }

        public void AddTransaction()
        {
            var CreateTranDTO = new CreateTransactionDTO
            {
                Name = this.view.TranName.Text,
                Description = this.view.Description.Text,
                TranType = (TranType)Enum.Parse(typeof(TranType), this.view.TranType.SelectedValue.ToString()),
                TranDate = this.view.TranDate.Value,
                ContactId = Int32.Parse(this.view.Contact.SelectedValue.ToString()),
                Amount = Decimal.Parse(this.view.Amount.Text),
                IsRecurring = this.view.IsRecurring.Checked,
                Frequency = (Frequency)Enum.Parse(typeof(Frequency), this.view.Frequency.SelectedValue.ToString()),
            };

            transactionService.AddTransaction(CreateTranDTO);
            RestFormFields();
            this.view.ShowMessage("Transaction successfully added.");
        }

        private void RestFormFields()
        {
            this.view.TranName.Clear();
            this.view.Description.Clear();
            this.view.TranType.SelectedIndex = 0;
            this.view.TranDate.Value = DateTime.Now;
            this.view.Contact.SelectedIndex = 0;
            this.view.Amount.Clear();
            this.view.IsRecurring.Checked = false;
            this.view.Frequency.SelectedIndex = 0;
        }
    }
}
