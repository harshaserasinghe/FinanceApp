using Finance.UI.Controllers;
using System.Windows.Forms;

namespace Finance.UI.Views
{
    public partial class TransactionView : Form
    {
        private TransactionController controller { get; set; }

        public TextBox TranName
        {
            get { return this.txbTranName; }
            set { this.txbTranName = value; }
        }

        public RichTextBox Description
        {
            get { return this.txbDescription; }
            set { this.txbDescription = value; }
        }

        public ComboBox TranType
        {
            get { return this.cmbTranType; }
            set { this.cmbTranType = value; }
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

        private void btnClickAddTransaction(object sender, System.EventArgs e)
        {
            this.controller.AddTransaction();
        }

        public void SetController(TransactionController controller)
        {
            this.controller = controller;
        }

        public void ShowMessage(string msg)
        {
            MessageBox.Show(msg);
        }
    }
}
