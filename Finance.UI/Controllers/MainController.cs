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
        }

        public void LoadView()
        {
            view.Show();
        }

        public void OpenTransactionForm()
        {
            var tranView = new TransactionView();
            var tranController = new TransactionController(tranView);
            tranController.Init();
            tranController.Show();
        }
    }
}
