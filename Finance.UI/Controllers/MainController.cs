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
            var transactionView = new TransactionView();
            var transactionController = new TransactionController(transactionView);
            transactionController.LoadView();
        }
    }
}
