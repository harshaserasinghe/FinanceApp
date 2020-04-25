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
    public class EventController
    {
        private readonly EventView view;
        private readonly EventService eventService;
        private readonly UserService userService;
        private readonly UserDto loggedUser;
        private readonly ContactService contactService;

        public EventDto SelectedEvntDto { get; set; }

        public EventController(EventView view)
        {
            this.view = view;
            this.view.SetController(this);
            eventService = new EventService();
            contactService = new ContactService();
            userService = new UserService();
            loggedUser = userService.GetUser(Environment.UserName);
        }

        public void Init()
        {
            view.EvntContact.DataSource = contactService.GetConts();
            view.EvntContact.DisplayMember = nameof(ContactDto.Name);
            view.EvntContact.ValueMember = nameof(ContactDto.ContactId);
            view.EvntTypeSearch.DataSource = Enum.GetValues(typeof(EventType));
            view.EvntType.DataSource = Enum.GetValues(typeof(EventType));
            view.EvntOccourence.DataSource = Enum.GetValues(typeof(Frequency));

            view.EvntTable.AutoGenerateColumns = false;
            view.EvntTable.AutoSize = true;
            view.EvntTable.MultiSelect = false;
            view.EvntTable.ScrollBars = ScrollBars.Vertical;
            view.EvntTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            
            //String eventEndTime;
            //String eventStartDate;
            //String eventEndTime;


            AddTexBoxColumn(nameof(EventDto.EventId), "Id", true, false);
            AddTexBoxColumn(nameof(EventDto.Name), "Name", true, true);
            AddTexBoxColumn(nameof(EventDto.Description), "Description", true, true);
            AddTexBoxColumn(nameof(EventDto.ContactId), "ContactId", true, false);
            AddTexBoxColumn(nameof(EventDto.ContactName), "Contact", true, true);
            AddTexBoxColumn(nameof(EventDto.EventType), "Type", true, true);
            AddTexBoxColumn(nameof(EventDto.EventStartDate), "StartDate", true, true);
            AddTexBoxColumn(nameof(EventDto.EventStartTime), "StartTime", true, true);
            AddTexBoxColumn(nameof(EventDto.EventEndDate), "EndDate", true, true);
            AddTexBoxColumn(nameof(EventDto.EventEndTime), "EndTime", true, true);
            AddTexBoxColumn(nameof(EventDto.IsRecurring), "Recurring", true, true);
            AddTexBoxColumn(nameof(EventDto.EventRecId), "TranRecId", true, false);
            AddTexBoxColumn(nameof(EventDto.Frequency), "Occurrence", true, true);
            IsReCurringEvnt();
        }

        public void Show()
        {
            view.Show();
        }

        public void GetEvents()
        {
            try
            {
                ClearTable();
                var evntDtos = eventService.GetEvntsByDate(loggedUser.UserId,
                    (EventType)Enum.Parse(typeof(EventType), view.EvntType.SelectedValue.ToString()),
                    view.EvntFrom.Value, view.EvntTo.Value);
                var bindingSource = new BindingSource(evntDtos, null);
                view.EvntTable.DataSource = bindingSource;
            }
            catch (Exception)
            {
                view.ShowMessage("Transaction get failed.","Error");
            }
        }

      

        public void AddEvent()
        {
            try
            {
                var createEvntDto = new CreateEventDto
                {
                    Name = view.EvntName.Text,
                    Description = view.EvntDescription.Text,
                    EventType = (EventType)Enum.Parse(typeof(EventType), view.EvntType.SelectedValue.ToString()),
                    EventStartDate = view.EvntStartDate.Value,
                    EventEndDate= view.EvntEndDate.Value,
                    EventStartTime = view.EvntStartTime.Value,
                    EventEndTime = view.EvntEndTime.Value,
                    ContactId = Int32.Parse(view.EvntContact.SelectedValue.ToString()),
                    IsRecurring = view.IsRecurring.Checked,
                    Frequency = (Frequency)Enum.Parse(typeof(Frequency), view.EvntOccourence.SelectedValue.ToString()),
                    UserId = loggedUser.UserId
                };

                eventService.AddEvnt(createEvntDto);
                GetEvents();
                ClearForm();
                view.ShowMessage("Event added successfully.","Information");
            }
            catch (Exception)
            {
             
                view.ShowMessage("Event add failed!","Error");
            }


        }

        public void UpdateEvent()
        {
            try
            {
                var updateEvntDto = new UpdateEventDto
                {
                    EventId = SelectedEvntDto.EventId,
                    Name = view.EvntName.Text,
                    Description = view.EvntDescription.Text,
                    EventType = (EventType)Enum.Parse(typeof(EventType), view.EvntType.SelectedValue.ToString()),
                    EventStartDate = view.EvntStartDate.Value,
                    EventEndDate = view.EvntEndDate.Value,
                    EventStartTime = view.EvntStartTime.Value,
                    EventEndTime = view.EvntEndTime.Value,
                    ContactId = Int32.Parse(view.EvntContact.SelectedValue.ToString()),
                    IsRecurring = view.IsRecurring.Checked,
                    EventRecId = SelectedEvntDto.EventRecId,
                    Frequency = (Frequency)Enum.Parse(typeof(Frequency), view.EvntOccourence.SelectedValue.ToString()),
                };

                eventService.UpdateEvnt(updateEvntDto);
                GetEvents();
                ClearForm();
                view.ShowMessage("Transaction update success.","Information");
            }
            catch (Exception e)
            {
                view.ShowMessage(e.ToString(),"Error");
                view.ShowMessage("Transaction update failed.","Error");
            }
        }

        public void DeleteEvnt()
        {
            try
            {
                //view.ShowMessage("Are you sure you want to delete this transaction?", "Warning");
                
              //  view.ShowDialog(("Are you sure you want to delete this transaction?", "Warning"));
                var evntId = SelectedEvntDto.EventId;
                eventService.DeleteEvnt(evntId);
                GetEvents();
                ClearForm();
                view.ShowMessage("Transaction delete success.","Information");
            }
            catch (Exception)
            {
                view.ShowMessage("Transaction delete failed.","Error");
            }
        }

        private void RefreshTable()
        {
            var evntDtos = (view.EvntTable.DataSource as BindingSource).List;
            var bindingSource = new BindingSource(evntDtos, null);
            view.EvntTable.DataSource = bindingSource;
        }

        public void IsReCurringEvnt()
        {
            if (view.IsRecurring.Checked)
                view.SecOccourence.Show();
            else
            {
                view.EvntOccourence.SelectedIndex = 0; 
                view.SecOccourence.Hide();
            }
        }

        public void IsAppointment()
        {
            if (view.EvntType.SelectedValue.ToString().Equals("Appointment"))
            {

                view.SecEvntContact.Show();
            }

            else
            {
                view.SecEvntContact.Hide();

            }
        }

        public void SetSelectedEvnt()
        {
            ClearForm();
            SelectedEvntDto = new EventDto();
            SelectedEvntDto = view.EvntTable.SelectedRows[0].DataBoundItem as EventDto;
            view.EvntName.Text = SelectedEvntDto.Name;
            view.EvntDescription.Text = SelectedEvntDto.Description;
            view.EvntType.SelectedItem = SelectedEvntDto.EventType;
            view.EvntStartDate.Value = SelectedEvntDto.EventStartDate;
            view.EvntEndDate.Value = SelectedEvntDto.EventEndDate;
            view.EvntStartTime.Value = SelectedEvntDto.EventStartTime;
            view.EvntEndTime.Value = SelectedEvntDto.EventEndTime;
            view.EvntContact.SelectedValue = SelectedEvntDto.ContactId;
            view.IsRecurring.Checked = SelectedEvntDto.IsRecurring;

            if (SelectedEvntDto.IsRecurring)
                view.EvntOccourence.SelectedItem = SelectedEvntDto.Frequency;
        }
        
        public void ClearForm()
        {
            view.EvntName.Clear();
            view.EvntDescription.Clear();
            view.EvntType.SelectedIndex = 0;
            view.EvntStartTime.Value = DateTime.Now;
            view.EvntEndTime.Value = DateTime.Now;
            view.EvntStartDate.Value = DateTime.Now;
            view.EvntStartDate.Value = DateTime.Now;
            view.EvntContact.SelectedIndex = 0;
            view.IsRecurring.Checked = false;
            view.EvntOccourence.SelectedIndex = 0;
            SelectedEvntDto = null;
        }

        public void ClearTable()
        {
            view.EvntTable.Rows.Clear();
            view.EvntTable.Refresh();
            SelectedEvntDto = null;
        }

        private void AddTexBoxColumn(string propName, string colName, bool isReadOnly, bool isVisible)
        {
            var col = new DataGridViewTextBoxColumn();
            col.DataPropertyName = propName;
            col.Name = colName;
            col.ReadOnly = isReadOnly;
            col.Visible = isVisible;
            view.EvntTable.Columns.Add(col);
        }

        private void AddComboBoxColumn(string prop, string colName, Type enumType, bool isReadOnly)
        {
            var col = new DataGridViewComboBoxColumn();
            col.DataSource = Enum.GetValues(enumType);
            col.DataPropertyName = prop;
            col.Name = colName;
            col.ReadOnly = isReadOnly;
            view.EvntTable.Columns.Add(col);
        }

        private void AddCheckBoxColumn(string prop, string colName, bool isReadOnly)
        {
            var col = new DataGridViewCheckBoxColumn();
            col.DataPropertyName = prop;
            col.Name = colName;
            col.ReadOnly = isReadOnly;
            view.EvntTable.Columns.Add(col);
        }
    }
}
