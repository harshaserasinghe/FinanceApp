using Finance.UI.Controllers;
using System.Windows.Forms;

namespace Finance.UI.Views
{
    public partial class ContactView : Form
    {
        private ContactController controller;

        public ContactView()
        {
            InitializeComponent();
        }

        public void SetController(ContactController controller)
        {
            this.controller = controller;
        }

        public TextBox ContName
        {
            get { return txbContName; }
            set { txbContName = value; }
        }

        public TextBox BusinessType
        {
            get { return txbBusinessType; }
            set { txbBusinessType = value; }
        }

        public TextBox Address
        {
            get { return txbAddress; }
            set { txbAddress = value; }
        }

        public TextBox PhoneNumber
        {
            get { return txbPhoneNumber; }
            set { txbPhoneNumber = value; }
        }

        public TextBox ContNameSearch
        {
            get { return txbContNameSearch; }
            set { txbContNameSearch = value; }
        }

        public DataGridView ContTable
        {
            get { return dgvContTable; }
            set { dgvContTable = value; }
        }

        public void ShowMessage(string msg)
        {
            MessageBox.Show(msg);
        }

        private void btnSearchClick(object sender, System.EventArgs e)
        {
            controller.GetConts();
        }
        private void btnCreateClick(object sender, System.EventArgs e)
        {
            controller.AddCont();
        }
        private void btnUpdateClick(object sender, System.EventArgs e)
        {
            controller.UpdateCont();
        }
        private void btnDeleteClick(object sender, System.EventArgs e)
        {
            controller.DeleteCont();
        }

        private void btnClearTableClick(object sender, System.EventArgs e)
        {
            controller.ClearTable();
        }
        private void btnClearFromClick(object sender, System.EventArgs e)
        {
            controller.ClearForm();
        }

        private void dgvContTableRowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            controller.SetSelectedCont();
        }
    }
}
