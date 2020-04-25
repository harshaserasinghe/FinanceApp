using Finance.Core.DTOs;
using Finance.Core.Entities;
using Finance.Service;
using Finance.UI.Views;
using System;
using System.Windows.Forms;
using System.Linq;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.WinForms;
using System.Collections.Generic;
using System.Windows.Media;
using System.Windows;

namespace Finance.UI.Controllers
{
    public class TransactionController
    {
        private readonly TransactionView view;
        private readonly ContactService contService;
        private readonly TransactionService tranService;
        private readonly UserService userService;
        private readonly UserDto loggedUser;

        public TransactionDto SelectedTranDto { get; set; }

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
            view.Contact.DataSource = contService.GetConts();
            view.Contact.DisplayMember = nameof(ContactDto.Name);
            view.Contact.ValueMember = nameof(ContactDto.ContactId);
            view.TranType.DataSource = Enum.GetValues(typeof(TranType));
            view.TranTypeSearch.DataSource = Enum.GetValues(typeof(TranType));
            view.Frequency.DataSource = Enum.GetValues(typeof(Frequency));

            view.TranTable.AutoGenerateColumns = false;
            view.TranTable.AutoSize = true;
            view.TranTable.MultiSelect = false;
            view.TranTable.ScrollBars = ScrollBars.Vertical;
            view.TranTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            AddTexBoxColumn(nameof(TransactionDto.TranId), "Id", true, false);
            AddTexBoxColumn(nameof(TransactionDto.Name), "Name", true, true);
            AddTexBoxColumn(nameof(TransactionDto.Description), "Description", true, true);
            AddTexBoxColumn(nameof(TransactionDto.ContactId), "ContactId", true, false);
            AddTexBoxColumn(nameof(TransactionDto.ContactName), "Contact", true, true);
            AddTexBoxColumn(nameof(TransactionDto.TranType), "Type", true, true);
            AddTexBoxColumn(nameof(TransactionDto.TranDate), "Date", true, true);
            AddTexBoxColumn(nameof(TransactionDto.Amount), "Amount", true, true);
            AddTexBoxColumn(nameof(TransactionDto.IsRecurring), "Recurring", true, true);
            AddTexBoxColumn(nameof(TransactionDto.TranRecId), "TranRecId", true, false);
            AddTexBoxColumn(nameof(TransactionDto.Frequency), "Occurrence", true, true);
            IsReCurringTran();
        }

        public void Show()
        {
            view.Show();
        }

        public void GetTrans()
        {
            try
            {
                ClearTable();
                var tranDtos = tranService.GetTransByDate(loggedUser.UserId,
                    (TranType)Enum.Parse(typeof(TranType), view.TranTypeSearch.SelectedValue.ToString()),
                    view.FromDate.Value, view.ToDate.Value);
                var bindingSource = new BindingSource(tranDtos, null);
                view.TranTable.DataSource = bindingSource;
            }
            catch (Exception)
            {
                view.ShowMessage("Transaction get failed.");
            }
        }

        public void AddTran()
        {
            try
            {
                var createTranDto = new CreateTransactionDto
                {
                    Name = view.TranName.Text,
                    Description = view.Description.Text,
                    TranType = (TranType)Enum.Parse(typeof(TranType), view.TranType.SelectedValue.ToString()),
                    TranDate = view.TranDate.Value,
                    ContactId = Int32.Parse(view.Contact.SelectedValue.ToString()),
                    Amount = Decimal.Parse(view.Amount.Text),
                    IsRecurring = view.IsRecurring.Checked,
                    Frequency = (Frequency)Enum.Parse(typeof(Frequency), view.Frequency.SelectedValue.ToString()),
                    UserId = loggedUser.UserId
                };

                tranService.AddTran(createTranDto);
                GetTrans();
                ClearForm();
                view.ShowMessage("Transaction add success.");
            }
            catch (Exception)
            {
                view.ShowMessage("Transaction add failed.");
            }
        }

        public void UpdateTran()
        {
            try
            {
                var updateTranDto = new UpdateTransactionDto
                {
                    TranId = SelectedTranDto.TranId,
                    Name = view.TranName.Text,
                    Description = view.Description.Text,
                    TranType = (TranType)Enum.Parse(typeof(TranType), view.TranType.SelectedValue.ToString()),
                    TranDate = view.TranDate.Value,
                    ContactId = Int32.Parse(view.Contact.SelectedValue.ToString()),
                    Amount = Decimal.Parse(view.Amount.Text),
                    IsRecurring = view.IsRecurring.Checked,
                    TranRecId = SelectedTranDto.TranRecId,
                    Frequency = (Frequency)Enum.Parse(typeof(Frequency), view.Frequency.SelectedValue.ToString()),
                };

                tranService.UpdateTran(updateTranDto);
                GetTrans();
                ClearForm();
                view.ShowMessage("Transaction update success.");
            }
            catch (Exception)
            {
                view.ShowMessage("Transaction update failed.");
            }
        }

        public void DeleteTran()
        {
            try
            {
                var tranId = SelectedTranDto.TranId;
                tranService.DeleteTran(tranId);
                GetTrans();
                ClearForm();
                view.ShowMessage("Transaction delete success.");
            }
            catch (Exception)
            {
                view.ShowMessage("Transaction delete failed.");
            }
        }

        public void GetForecast()
        {
            var forecast = tranService.GetForecast(loggedUser.UserId, view.ForecastDate.Value);
            var formatForcast = $"Expense forecast of the {view.ForecastDate.Value.ToShortDateString()} will be Rs {forecast.ToString(".00")}";
            view.Forecast.Text = formatForcast;
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
            {
                view.RecSection.Show();
            }

            else
            {
                view.Frequency.SelectedIndex = 0;
                view.RecSection.Hide();
            }
                
        }

        public void SetSelectedTran()
        {
            ClearForm();
            SelectedTranDto = new TransactionDto();
            SelectedTranDto = view.TranTable.SelectedRows[0].DataBoundItem as TransactionDto;
            view.TranName.Text = SelectedTranDto.Name;
            view.Description.Text = SelectedTranDto.Description;
            view.TranType.SelectedItem = SelectedTranDto.TranType;
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
            SelectedTranDto = null;
        }

        public void ClearForm()
        {
            view.TranName.Clear();
            view.Description.Clear();
            view.TranType.SelectedIndex = 0;
            view.TranDate.Value = DateTime.Now;
            view.Contact.SelectedIndex = 0;
            view.Amount.Clear();
            view.IsRecurring.Checked = false;
            view.Frequency.SelectedIndex = 0;
            SelectedTranDto = null;
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
