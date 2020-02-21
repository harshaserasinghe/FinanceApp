using Autofac;
using Finance.Core.DTOs;
using Finance.Core.Entities;
using Finance.Service;
using System;
using System.Windows.Forms;

namespace Finance.UI
{
    public partial class Form1 : Form
    {
        private static IContainer Container { get; set; }
        public Form1()
        {
            RegisterDependancies();
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (var scope = Container.BeginLifetimeScope())
            {
                var tranService = scope.Resolve<ITransactionService>();

                var createTransaction = new CreateTransaction
                {
                    Name = "Transaction test",
                    TranDate = DateTime.Now,
                    TranType = TranType.Credit,
                    Amount = 1000,
                    IsRecurring = false,
                    ContactId = 1
                };

                tranService.AddTransaction(createTransaction);
            }
        }

        private static void RegisterDependancies()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<TransactionService>().As<ITransactionService>();
            //builder.RegisterType<FinanceDbContext>();
            Container = builder.Build();

        }


    }
}
