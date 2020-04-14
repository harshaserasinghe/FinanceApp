using Finance.Core.DTOs;
using Finance.Core.Entities;
using Finance.Service;
using Finance.UI.Views;
using System;
using System.Windows.Forms;

namespace Finance.UI.Controllers
{
    public class TransactionController
    {
        private TransactionView view { get; set; }
        private ContactService contactService { get; }
        private TransactionService transactionService { get; }

        private readonly UserService userService;

        private readonly UserDTO loggedUser;

        public TransactionController(TransactionView view)
        {
            this.view = view;
            this.view.SetController(this);
            contactService = new ContactService();
            transactionService = new TransactionService();
            userService = new UserService();
            loggedUser = userService.GetUser(Environment.UserName);
        }

        public void LoadView()
        {
            this.view.Contact.DataSource = contactService.GetContacts();
            this.view.Contact.DisplayMember = nameof(ContactDTO.Name);
            this.view.Contact.ValueMember = nameof(ContactDTO.ContactId);

            this.view.TranType.DataSource = Enum.GetValues(typeof(TranType));
            this.view.TranTypeSearch.DataSource = Enum.GetValues(typeof(TranType));
            this.view.Frequency.DataSource = Enum.GetValues(typeof(Frequency));

            this.view.TranView.AutoGenerateColumns = false;
            this.view.TranView.AutoSize = true;
            //AddTexBoxColumn(nameof(TransactionDTO.TranId), "Id", true);
            //AddTexBoxColumn(nameof(TransactionDTO.Name), "Name", false);
            //AddComboBoxColumn(nameof(TransactionDTO.TranType), "Type", typeof(TranType), false);
            //AddTexBoxColumn(nameof(TransactionDTO.TranDate), "Date", false);
            //AddTexBoxColumn(nameof(TransactionDTO.Amount), "Amount", false);
            //AddCheckBoxColumn(nameof(TransactionDTO.IsRecurring), "Recurring", false);
            //AddTexBoxColumn(nameof(TransactionDTO.ContactName), "Contact", false);
            //AddComboBoxColumn(nameof(CreateTransactionDTO.Frequency), "Occurrence", typeof(Frequency), false);

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
                UserId = loggedUser.UserId
            };

            transactionService.AddTransaction(CreateTranDTO);
            RestFormFields();
            this.view.ShowMessage("Transaction successfully added.");
        }

        public void DeleteTransaction()
        {
            throw new NotImplementedException();
        }

        public void UpdateTransaction()
        {
            var row = this.view.TranView.SelectedRows;
        }

        public void GetTransaction()
        {
            var tranDtos = transactionService.GetTransactionsByDate(loggedUser.UserId,
                (TranType)Enum.Parse(typeof(TranType), this.view.TranTypeSearch.SelectedValue.ToString()),
                this.view.FromDate.Value, this.view.ToDate.Value);
            var bindingSource = new BindingSource(tranDtos, null);
            this.view.TranView.DataSource = bindingSource;
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

        private void AddTexBoxColumn(string propName, string colName, bool isReadOnly)
        {
            var col = new DataGridViewTextBoxColumn();
            col.DataPropertyName = propName;
            col.Name = colName;
            col.ReadOnly = isReadOnly;
            this.view.TranView.Columns.Add(col);
        }

        private void AddComboBoxColumn(string prop, string colName, Type enumType, bool isReadOnly)
        {
            var col = new DataGridViewComboBoxColumn();
            col.DataSource = Enum.GetValues(enumType);
            col.DataPropertyName = prop;
            col.Name = colName;
            col.ReadOnly = isReadOnly;
            this.view.TranView.Columns.Add(col);
        }

        private void AddCheckBoxColumn(string prop, string colName, bool isReadOnly)
        {
            var col = new DataGridViewCheckBoxColumn();
            col.DataPropertyName = prop;
            col.Name = colName;
            col.ReadOnly = isReadOnly;
            this.view.TranView.Columns.Add(col);
        }
    }
}
