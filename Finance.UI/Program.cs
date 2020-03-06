using Finance.UI.Controllers;
using Finance.UI.Views;
using System;
using System.Windows.Forms;

namespace Finance.UI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mainView = new MainForm();
            var mainController = new MainController(mainView);
            mainController.LoadView();
            Application.Run();
        }
    }
}
