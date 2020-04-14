using Finance.UI.Controllers;
using System.Windows.Forms;

namespace Finance.UI.Views
{
    public partial class TransactionView : Form
    {
        private TransactionController controller { get; set; }

        public TextBox TranName
        {
            get { return this.txbTranManager; }
            set { this.txbTranManager = value; }
        }

        public RichTextBox Description
        {
            get { return this.txbDescription; }
            set { this.txbDescription = value; }
        }

        public ComboBox TranType
        {
            get { return this.cmbTranTypeManage; }
            set { this.cmbTranTypeManage = value; }
        }

        public DateTimePicker TranDate
        {
            get { return this.dtpTranDate; }
            set { this.dtpTranDate = value; }
        }

        public TextBox Amount
        {
            get { return this.txbAmount; }
            set { this.txbAmount = value; }
        }

        public ComboBox Contact
        {
            get { return this.cmbContact; }
            set { this.cmbContact = value; }
        }

        public CheckBox IsRecurring
        {
            get { return this.chbIsRecurring; }
            set { this.chbIsRecurring = value; }
        }
        public ComboBox Frequency
        {
            get { return this.cmbFrequency; }
            set { this.cmbFrequency = value; }
        }

        public TransactionView()
        {
            InitializeComponent();
        }

        public ComboBox TranTypeSearch
        {
            get { return this.cmbTranTypeManage; }
            set { this.cmbTranTypeManage = value; }
        }
        public DateTimePicker FromDate
        {
            get { return this.dtpFromDate; }
            set { this.dtpFromDate = value; }
        }
        public DateTimePicker ToDate
        {
            get { return this.dtpToDate; }
            set { this.dtpToDate = value; }
        }

        public DataGridView TranView
        {
            get { return this.dgvTran; }
            set { this.dgvTran = value; }
        }

        public void SetController(TransactionController controller)
        {
            this.controller = controller;
        }

        public void ShowMessage(string msg)
        {
            MessageBox.Show(msg);
        }

        private void btnClickGetTran(object sender, System.EventArgs e)
        {
            this.controller.GetTransaction();
        }
        private void btnClickDeleteTran(object sender, System.EventArgs e)
        {
            this.controller.AddTransaction();
        }
        private void btnClickUpdateTran(object sender, System.EventArgs e)
        {
            this.controller.UpdateTransaction();
        }
        private void btnClickTranDelete(object sender, System.EventArgs e)
        {
            this.controller.DeleteTransaction();
        }
    }
}
