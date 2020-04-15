﻿using Finance.Core.DTOs;
using Finance.Service;
using Finance.UI.Views;
using System;
using System.Windows.Forms;

namespace Finance.UI.Controllers
{
    public class ContactController
    {
        private readonly ContactService contService;
        private readonly UserService userService;
        private readonly UserDto loggedUser;
        private ContactView view;

        public ContactDto SelectedContDto { get; private set; }

        public ContactController(ContactView view)
        {
            this.view = view;
            this.view.SetController(this);
            contService = new ContactService();
            userService = new UserService();
            loggedUser = userService.GetUser(Environment.UserName);
        }

        public void Init()
        {
            view.ContTable.AutoGenerateColumns = false;
            view.ContTable.AutoSize = true;
            view.ContTable.MultiSelect = false;
            view.ContTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            AddTexBoxColumn(nameof(ContactDto.ContactId), "Id", true, false);
            AddTexBoxColumn(nameof(ContactDto.Name), "Name", true, true);
            AddTexBoxColumn(nameof(ContactDto.BusinessType), "Business", true, true);
            AddTexBoxColumn(nameof(ContactDto.Address), "Address", true, true);
            AddTexBoxColumn(nameof(ContactDto.PhoneNumber), "Phone", true, true);
        }

        public void Show()
        {
            view.Show();
        }

        public void GetConts()
        {
            ClearTable();
            var contName = view.ContNameSearch.Text;
            var contDtos = contService.GetContsByName(contName);
            var bindingSource = new BindingSource(contDtos, null);
            view.ContTable.DataSource = bindingSource;
        }

        public void AddCont()
        {
            var createContDto = new CreateContactDto
            {
                Name = view.ContName.Text,
                BusinessType = view.BusinessType.Text,
                Address = view.Address.Text,
                PhoneNumber = view.PhoneNumber.Text
            };

            contService.AddCont(createContDto);
            GetConts();
            ClearForm();
            view.ShowMessage("Contact successfully added.");
        }

        public void UpdateCont()
        {
            var updateContDto = new UpdateContactDto
            {
                ContactId = SelectedContDto.ContactId,
                Name = view.ContName.Text,
                BusinessType = view.BusinessType.Text,
                Address = view.Address.Text,
                PhoneNumber = view.PhoneNumber.Text
            };

            contService.UpdateContact(updateContDto);
            GetConts();
            ClearForm();
            view.ShowMessage("Contact successfully updated.");
        }

        public void DeleteCont()
        {
            var contId = SelectedContDto.ContactId;
            contService.DeleteCont(contId);
            GetConts();
            ClearForm();
            view.ShowMessage("Contact successfully Deleted.");
        }

        public void SetSelectedCont()
        {
            if (view.ContTable.SelectedRows.Count < 1)
                return;

            ClearForm();
            SelectedContDto = new ContactDto();
            SelectedContDto = view.ContTable.SelectedRows[0].DataBoundItem as ContactDto;
            view.ContName.Text = SelectedContDto.Name;
            view.BusinessType.Text = SelectedContDto.BusinessType;
            view.Address.Text = SelectedContDto.Address;
            view.PhoneNumber.Text = SelectedContDto.PhoneNumber;
        }

        public void ClearTable()
        {
            view.ContTable.Rows.Clear();
            view.ContTable.Refresh();
            SelectedContDto = null;
        }

        public void ClearForm()
        {
            view.ContName.Clear();
            view.BusinessType.Clear();
            view.Address.Clear();
            view.PhoneNumber.Clear();
            SelectedContDto = null;
        }

        private void AddTexBoxColumn(string propName, string colName, bool isReadOnly, bool isVisible)
        {
            var col = new DataGridViewTextBoxColumn();
            col.DataPropertyName = propName;
            col.Name = colName;
            col.ReadOnly = isReadOnly;
            col.Visible = isVisible;
            view.ContTable.Columns.Add(col);
        }
    }
}
