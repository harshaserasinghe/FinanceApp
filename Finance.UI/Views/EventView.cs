using Finance.UI.Controllers;
using System.Windows.Forms;

namespace Finance.UI.Views
{
    public partial class EventView : Form
    {
        private EventController controller;
        public EventView()
        {
            InitializeComponent();
        }
        public void SetController(EventController controller)
        {
            this.controller = controller;
        }

        public TextBox EvntName
        {
            get { return txbEvntName; }
            set { txbEvntName = value; }
        }

        public TextBox EvntDescription
        {
            get { return txbEvntDescription; }
            set { txbEvntDescription = value; }
        }

        public ComboBox EvntType
        {
            get { return cmbEvntType; }
            set { cmbEvntType = value; }
        }

        public ComboBox EvntContact
        {
            get { return cmbEvntContact; }
            set { cmbEvntContact = value; }

        }

        public Panel SecEvntContact
        {
            get { return pnlEvntContact;}
            set { pnlEvntContact = value; }

        }

        public DateTimePicker EvntStartDate
        {
            get { return dtpEventStartDate; }
            set { dtpEventStartDate = value; }

        }

        public DateTimePicker EvntEndDate
        {
            get { return dtpEvntEndDate; }
            set { dtpEvntEndDate = value; }

        }

        public DateTimePicker EvntStartTime
        {
            get { return dtpEvntStartTime; }
            set { dtpEvntStartTime = value; }

        }

        public DateTimePicker EvntEndTime
        {
            get { return dtpEvntEndTime; }
            set { dtpEvntEndTime = value; }

        }

        public CheckBox IsRecurring
        {
            get { return chbIsEvntRecurring; }
            set { chbIsEvntRecurring = value; }

        }

        public Panel SecOccourence
        {
            get { return pnlEvntOccourence; }
            set { pnlEvntOccourence = value; }

        }

        public ComboBox EvntOccourence
        {
            get { return cmbEvntOccurrence; }
            set { cmbEvntOccurrence = value; }
        }

        public ComboBox EvntTypeSearch
        {
            get { return cmbEvntTypeSearch; }
            set { cmbEvntTypeSearch = value; }
        }

        public DateTimePicker EvntFrom
        {
            get { return dtpEvntStartSearch; }
            set { dtpEvntStartSearch = value; }

        }

        public DateTimePicker EvntTo
        {
            get { return dtpEvntEndSearch; }
            set { dtpEvntEndSearch = value; }

        }

        public DataGridView EvntTable
        {
            get { return dgvEvntTable; }
            set { dgvEvntTable = value; }
        }

        public void ShowMessage(string msg, string type)
        {
            if (type.Equals("Error"))
            {
                MessageBox.Show(msg,type, MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }

            else {
                MessageBox.Show(msg,type, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            } 
        }

        private void btnEvntSearch_Click(object sender, System.EventArgs e)
        {
            controller.GetEvents();
        }

        private void btnEvntAdd_Click(object sender, System.EventArgs e)
        {
            controller.AddEvent();
        }

        private void btnEvntUpdate_Click(object sender, System.EventArgs e)
        {
            controller.UpdateEvent();
        }

        private void btnEvntDelete_Click(object sender, System.EventArgs e)
        {
            controller.DeleteEvnt();
        }

        private void chbIsEvntRecurring_CheckedChanged(object sender, System.EventArgs e)
        {
            controller.IsReCurringEvnt();
        }

        private void btnEvntClear_Click(object sender, System.EventArgs e)
        {
            controller.ClearForm();
        }

        private void btnEvntSearchClear_Click(object sender, System.EventArgs e)
        {
            controller.ClearTable();
        }

        private void cmbEvntType_SelectedValueChanged(object sender, System.EventArgs e)
        {
            controller.IsAppointment();
        }

        private void dgvEvntTable_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            controller.SetSelectedEvnt();
        }
    }
}
