using Finance.UI.Controllers;
using System.Windows.Forms;

namespace Finance.UI.Views
{
    public partial class MainForm : Form
    {
        private MainController controller { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        public void SetController(MainController controller)
        {
            this.controller = controller;
        }

        private void btnClickOpenTransactionForm(object sender, System.EventArgs e)
        {
            this.controller.OpenTransactionForm();            
        }

        private void btnClickOpenContactForm(object sender, System.EventArgs e)
        {
            var contactForm = new ContactForm();
            contactForm.Show();
        }

        private void btnClickOpenEvenForm(object sender, System.EventArgs e)
        {
            var eventForm = new EventForm();
            eventForm.Show();
        }
    }
}
