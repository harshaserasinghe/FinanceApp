using Autofac;
using Finance.Data;
using Finance.Service;
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
            //RegisterDependancies();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }


 
    }
}
