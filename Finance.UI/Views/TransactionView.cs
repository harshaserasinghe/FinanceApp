using Finance.UI.Controllers;
using System.Windows.Forms;


namespace Finance.UI.Views
{
    public partial class TransactionView : Form
    {
        private TransactionController controller;

        public TransactionView()
        {
            InitializeComponent();
        }

        public void SetController(TransactionController controller)
        {
            this.controller = controller;
        }

        public TextBox TranName
        {
            get { return txbTranName; }
            set { txbTranName = value; }
        }

        public RichTextBox Description
        {
            get { return txbDescription; }
            set { txbDescription = value; }
        }

        public ComboBox TranType
        {
            get { return cmbTranType; }
            set { cmbTranType = value; }
        }

        public DateTimePicker TranDate
        {
            get { return dtpTranDate; }
            set { dtpTranDate = value; }
        }

        public TextBox Amount
        {
            get { return txbAmount; }
            set { txbAmount = value; }
        }

        public ComboBox Contact
        {
            get { return cmbContact; }
            set { cmbContact = value; }
        }

        public CheckBox IsRecurring
        {
            get { return chbIsRecurring; }
            set { chbIsRecurring = value; }
        }
        public ComboBox Frequency
        {
            get { return cmbFrequency; }
            set { cmbFrequency = value; }
        }

        public Panel RecSection
        {
            get { return panRecSection; }
            set { panRecSection = value; }
        }

        public ComboBox TranTypeSearch
        {
            get { return cmbTranTypeSearch; }
            set { cmbTranTypeSearch = value; }
        }
        public DateTimePicker FromDate
        {
            get { return dtpFromDate; }
            set { dtpFromDate = value; }
        }
        public DateTimePicker ToDate
        {
            get { return dtpToDate; }
            set { dtpToDate = value; }
        }

        public DataGridView TranTable
        {
            get { return dgvTranTable; }
            set { dgvTranTable = value; }
        }

        public Label Forecast
        {
            get { return labForecast; }
            set { labForecast = value; }
        }

        public DateTimePicker ForecastDate
        {
            get { return dtpForecast; }
            set { dtpForecast = value; }
        }

        public void ShowMessage(string msg)
        {
            MessageBox.Show(msg);
        }

        private void btnSearchClick(object sender, System.EventArgs e)
        {
            controller.GetTrans();
        }
        private void btnCreateClick(object sender, System.EventArgs e)
        {
            controller.AddTran();
        }
        private void btnUpdateClick(object sender, System.EventArgs e)
        {
            controller.UpdateTran();
        }
        private void btnDeleteClick(object sender, System.EventArgs e)
        {
            controller.DeleteTran();
        }

        private void chbIsRecurringCheckedChanged(object sender, System.EventArgs e)
        {
            controller.IsReCurringTran();
        }
        private void btnClearTableClick(object sender, System.EventArgs e)
        {
            controller.ClearTable();
        }
        private void btnClearFromClick(object sender, System.EventArgs e)
        {
            controller.ClearForm();
        }

        private void dgvTranTableRowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            controller.SetSelectedTran();
        }

        private void btnGetForecastClick(object sender, System.EventArgs e)
        {
            controller.GetForecast();
        }
    }
}
