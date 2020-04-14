using Finance.Core.DTOs;
using Finance.Core.Entities;
using Finance.Service;
using Finance.UI.Views;
using System;
using System.Windows.Forms;
using System.Linq;

namespace Finance.UI.Controllers
{
    public class TransactionController
    {
        private readonly TransactionView view;
        private readonly ContactService contService;
        private readonly TransactionService tranService;
        private readonly UserService userService;
        private readonly UserDto loggedUser;

        public TransactionDTO SelectedTranDto { get; set; }

        public TransactionController(TransactionView view)
        {
            this.view = view;
            this.view.SetController(this);
            contService = new ContactService();
            tranService = new TransactionService();
            userService = new UserService();
            loggedUser = userService.GetUser(Environment.UserName);
        }

        public void Init()
        {
            view.Contact.DataSource = contService.GetContacts();
            view.Contact.DisplayMember = nameof(ContactDto.Name);
            view.Contact.ValueMember = nameof(ContactDto.ContactId);
            view.TranTypeManage.DataSource = Enum.GetValues(typeof(TranType));
            view.TranTypeSearch.DataSource = Enum.GetValues(typeof(TranType));
            view.Frequency.DataSource = Enum.GetValues(typeof(Frequency));

            view.TranTable.AutoGenerateColumns = false;
            view.TranTable.AutoSize = true;
            view.TranTable.MultiSelect = false;
            view.TranTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            AddTexBoxColumn(nameof(TransactionDTO.TranId), "Id", true, false);
            AddTexBoxColumn(nameof(TransactionDTO.Name), "Name", true, true);
            AddTexBoxColumn(nameof(TransactionDTO.Description), "Description", true, true);
            AddTexBoxColumn(nameof(TransactionDTO.ContactId), "ContactId", true, false);
            AddTexBoxColumn(nameof(TransactionDTO.ContactName), "Contact", true, true);
            AddTexBoxColumn(nameof(TransactionDTO.TranType), "Type", true, true);
            AddTexBoxColumn(nameof(TransactionDTO.TranDate), "Date", true, true);
            AddTexBoxColumn(nameof(TransactionDTO.Amount), "Amount", true, true);
            AddTexBoxColumn(nameof(TransactionDTO.IsRecurring), "Recurring", true, true);
            AddTexBoxColumn(nameof(TransactionDTO.TranRecId), "TranRecId", true, false);
            AddTexBoxColumn(nameof(TransactionDTO.Frequency), "Occurrence", true, true);
            IsReCurringTran();
        }

        public void Show()
        {
            view.Show();
        }

        public void AddTran()
        {
            var createTranDto = new CreateTransactionDto
            {
                Name = view.Name1.Text,
                Description = view.Description.Text,
                TranType = (TranType)Enum.Parse(typeof(TranType), view.TranTypeManage.SelectedValue.ToString()),
                TranDate = view.TranDate.Value,
                ContactId = Int32.Parse(view.Contact.SelectedValue.ToString()),
                Amount = Decimal.Parse(view.Amount.Text),
                IsRecurring = view.IsRecurring.Checked,
                Frequency = (Frequency)Enum.Parse(typeof(Frequency), view.Frequency.SelectedValue.ToString()),
                UserId = loggedUser.UserId
            };

            tranService.AddTransaction(createTranDto);
            GetTrans();
            ClearForm();
            view.ShowMessage("Transaction successfully added.");
        }

        public void UpdateTran()
        {
            var updateTranDto = new UpdateTransactionDto
            {
                TranId = SelectedTranDto.TranId,
                Name = view.Name1.Text,
                Description = view.Description.Text,
                TranType = (TranType)Enum.Parse(typeof(TranType), view.TranTypeManage.SelectedValue.ToString()),
                TranDate = view.TranDate.Value,
                ContactId = Int32.Parse(view.Contact.SelectedValue.ToString()),
                Amount = Decimal.Parse(view.Amount.Text),
                IsRecurring = view.IsRecurring.Checked,
                TranRecId = SelectedTranDto.TranRecId,
                Frequency = (Frequency)Enum.Parse(typeof(Frequency), view.Frequency.SelectedValue.ToString()),
            };

            tranService.UpdateTransaction(updateTranDto);
            GetTrans();
            ClearForm();
            view.ShowMessage("Transaction successfully updated.");
        }

        public void GetTrans()
        {
            var tranDtos = tranService.GetTransactionsByDate(loggedUser.UserId,
                (TranType)Enum.Parse(typeof(TranType), view.TranTypeSearch.SelectedValue.ToString()),
                view.FromDate.Value, view.ToDate.Value);
            var bindingSource = new BindingSource(tranDtos, null);
            view.TranTable.DataSource = bindingSource;
            ClearForm();
        }

        public void DeleteTran()
        {
            var tranId = SelectedTranDto.TranId;
            tranService.DeleteTran(tranId);
            GetTrans();
            ClearForm();
            view.ShowMessage("Transaction successfully Deleted.");
        }

        private void RefreshTable()
        {
            var tranDtos = (view.TranTable.DataSource as BindingSource).List;
            var bindingSource = new BindingSource(tranDtos, null);
            view.TranTable.DataSource = bindingSource;
        }

        public void IsReCurringTran()
        {
            if (view.IsRecurring.Checked)
                view.RecSection.Show();
            else
                view.RecSection.Hide();
        }

        public void SetSelectedTran()
        {
            if (view.TranTable.SelectedRows.Count < 1)
                return;

            SelectedTranDto = new TransactionDTO();
            SelectedTranDto = view.TranTable.SelectedRows[0].DataBoundItem as TransactionDTO;
            view.Name1.Text = SelectedTranDto.Name;
            view.Description.Text = SelectedTranDto.Description;
            view.TranTypeManage.SelectedItem = SelectedTranDto.TranType;
            view.TranDate.Value = SelectedTranDto.TranDate;
            view.Contact.SelectedValue = SelectedTranDto.ContactId;
            view.Amount.Text = SelectedTranDto.Amount.ToString();
            view.IsRecurring.Checked = SelectedTranDto.IsRecurring;

            if (SelectedTranDto.IsRecurring)
                view.Frequency.SelectedItem = SelectedTranDto.Frequency;
        }

        public void ClearTable()
        {
            view.TranTable.Rows.Clear();
            view.TranTable.Refresh();
        }


        public void ClearForm()
        {
            SelectedTranDto = new TransactionDTO();
            view.Name1.Clear();
            view.Description.Clear();
            view.TranTypeManage.SelectedIndex = 0;
            view.TranDate.Value = DateTime.Now;
            view.Contact.SelectedIndex = 0;
            view.Amount.Clear();
            view.IsRecurring.Checked = false;
            view.Frequency.SelectedIndex = 0;
        }

        private void AddTexBoxColumn(string propName, string colName, bool isReadOnly, bool isVisible)
        {
            var col = new DataGridViewTextBoxColumn();
            col.DataPropertyName = propName;
            col.Name = colName;
            col.ReadOnly = isReadOnly;
            col.Visible = isVisible;
            view.TranTable.Columns.Add(col);
        }

        private void AddComboBoxColumn(string prop, string colName, Type enumType, bool isReadOnly)
        {
            var col = new DataGridViewComboBoxColumn();
            col.DataSource = Enum.GetValues(enumType);
            col.DataPropertyName = prop;
            col.Name = colName;
            col.ReadOnly = isReadOnly;
            view.TranTable.Columns.Add(col);
        }

        private void AddCheckBoxColumn(string prop, string colName, bool isReadOnly)
        {
            var col = new DataGridViewCheckBoxColumn();
            col.DataPropertyName = prop;
            col.Name = colName;
            col.ReadOnly = isReadOnly;
            view.TranTable.Columns.Add(col);
        }
    }
}
