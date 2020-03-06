using Finance.UI.Views;

namespace Finance.UI.Controllers
{
    public class MainController
    {
        private MainForm view { get; }

        public MainController(MainForm view)
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
            var transactionView = new TransactionForm();
            var transactionController = new TransactionController(transactionView);
            transactionController.LoadView();
        }
    }
}
