using Finance.Data;
using Finance.Service;
using Finance.UI.Views;

namespace Finance.UI.Controllers
{
    public class MainController
    {
        private MainView view { get; }

        public MainController(MainView view)
        {
            this.view = view;
            this.view.SetController(this);
            FileService.Init();
            FinanceDbContext.Init();
        }

        public void LoadView()
        {
            view.Show();
        }

        public void OpenTranForm()
        {
            var tranView = new TransactionView();
            var tranController = new TransactionController(tranView);
            tranController.Init();
            tranController.Show();
        }

        public void OpenContForm()
        {
            var contView = new ContactView();
            var contController = new ContactController(contView);
            contController.Init();
            contController.Show();
        }

        public void OpenEvntForm()
        {
            var evntView = new EventView();
            var evntController = new EventController(evntView);
            evntController.Init();
            evntController.Show();
        }

        public void OpenRptForm()
        {
            var rptView = new ReportView();
            var contController = new ReportController(rptView);
            contController.Init();
            contController.Show();
        }
    }
}
