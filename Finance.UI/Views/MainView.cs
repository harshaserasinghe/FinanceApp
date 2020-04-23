using Finance.UI.Controllers;
using System.Windows.Forms;

namespace Finance.UI.Views
{
    public partial class MainView : Form
    {
        private MainController controller { get; set; }
        public MainView()
        {
            InitializeComponent();
        }

        public void SetController(MainController controller)
        {
            this.controller = controller;
        }

        private void btnClickOpenTransactionForm(object sender, System.EventArgs e)
        {
            controller.OpenTranForm();
        }

        private void btnClickOpenContactForm(object sender, System.EventArgs e)
        {
            controller.OpenContForm();
        }

        private void btnClickOpenEvenForm(object sender, System.EventArgs e)
        {
            var eventForm = new EventView();
            eventForm.Show();
        }

        private void btnClickOpenReportForm(object sender, System.EventArgs e)
        {
            controller.OpenRptForm();
        }

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
