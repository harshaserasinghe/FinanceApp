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
    }
}
