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

        public void ShowMessage(string msg, string type)
        {
            if (type.Equals("Error"))
            {
                MessageBox.Show(msg, type, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (type.Equals("Information"))
            {
                MessageBox.Show(msg, type, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (type.Equals("Warning"))
            {
                MessageBox.Show(msg, type, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        public bool ConfirmDelete()
        {
            if (MessageBox.Show("Are you sure you want to delete this Contact? All the associated Transactions and Events will be deleted along with the selected contact.", "Confirmation", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }

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
