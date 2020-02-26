using Finance.Core.DTOs;
using Finance.Core.Entities;
using Finance.Service;
using System;
using System.Windows.Forms;

namespace Finance.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tranService = new TransactionService();

            //var fromDate = DateTime.Now.AddDays(-2);
            //var toDate = DateTime.Now;
            //tranService.GetTransactionsByDate(fromDate, toDate);

            //var createTransaction = new CreateTransactionDTO
            //{
            //    Name = "Transaction test 5",
            //    TranDate = DateTime.Now.AddDays(-5),
            //    TranType = TranType.Credit,
            //    Amount = 5000,
            //    IsRecurring = false,
            //    ContactId = 1
            //};

            var updateTransactionDTO = new UpdateTransactionDTO
            {
                TranId = 5,
                Name = "Transaction test 5",
                TranDate = DateTime.Now.AddDays(5),
                TranType = TranType.Debet,
                Amount = 2500,
                IsRecurring = false,
                ContactId = 1
            };

            tranService.UpdateTransaction(updateTransactionDTO);

            //tranService.AddTransaction(createTransaction);

            //var tranDTO = tranService.GetTransaction(1);

        }
    }
}
