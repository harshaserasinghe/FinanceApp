using Finance.UI.Controllers;
using System.Windows.Forms;

namespace Finance.UI.Views
{
    public partial class TransactionForm : Form
    {
        private TransactionController controller { get; set; }

        public ComboBox Contacts
        {
            get { return this.cmbContact; }
            set { this.cmbContact = value; }
        }

        public ComboBox TransactionTypes
        {
            get { return this.cmbType; }
            set { this.cmbType = value; }
        }

        public ComboBox Frequencies
        {
            get { return this.cmbFrequency; }
            set { this.cmbFrequency = value; }
        }

        public TransactionForm()
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
    }
}
