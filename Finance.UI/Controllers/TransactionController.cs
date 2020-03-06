using Finance.Core.DTOs;
using Finance.Core.Entities;
using Finance.Service;
using Finance.UI.Views;
using System;

namespace Finance.UI.Controllers
{
    public class TransactionController
    {
        private TransactionForm view { get; set; }
        private ContactService contactService { get; }
        private TransactionService transactionService { get; }
        public TransactionController(TransactionForm view)
        {
            this.view = view;
            this.view.SetController(this);
            contactService = new ContactService();
            transactionService = new TransactionService();
        }

        public void LoadView()
        {
            this.view.Contacts.DataSource = contactService.GetContacts();
            this.view.Contacts.DisplayMember = nameof(ContactDTO.Name);
            this.view.Contacts.ValueMember = nameof(ContactDTO.ContactId);

            this.view.TransactionTypes.DataSource = Enum.GetValues(typeof(TranType));
            this.view.Frequencies.DataSource = Enum.GetValues(typeof(Frequency));

            this.view.Show();
        }

        public void AddTransaction()
        {
            throw new NotImplementedException();
        }
    }
}
