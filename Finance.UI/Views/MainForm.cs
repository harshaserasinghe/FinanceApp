using System.Windows.Forms;

namespace Finance.UI.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenTransactionForm(object sender, System.EventArgs e)
        {
            var transactionForm = new TransactionForm();
            transactionForm.Show();
        }

        private void OpenContactForm(object sender, System.EventArgs e)
        {
            var contactForm = new ContactForm();
            contactForm.Show();
        }

        private void OpenEvenForm(object sender, System.EventArgs e)
        {
            var eventForm = new EventForm();
            eventForm.Show();
        }
    }
}
