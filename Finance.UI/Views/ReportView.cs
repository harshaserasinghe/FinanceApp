using Finance.UI.Controllers;
using LiveCharts.WinForms;
using System;
using System.Windows.Forms;

namespace Finance.UI.Views
{
    public partial class ReportView : Form
    {
        private ReportController controller;

        public ReportView()
        {
            InitializeComponent();
        }

        public void SetController(ReportController controller)
        {
            this.controller = controller;
        }

        public DateTimePicker FromDate
        {
            get { return dtpFromDate; }
            set { dtpFromDate = value; }
        }
        public DateTimePicker ToDate
        {
            get { return dtpToDate; }
            set { dtpToDate = value; }
        }
        public CartesianChart TranSum
        {
            get { return colChtTraSum; }
            set { colChtTraSum = value; }
        }

        public PieChart ContExpBrkDwn
        {
            get { return pieChtContExpBrkDwn; }
            set { pieChtContExpBrkDwn = value; }
        }

        public CartesianChart TranByDate
        {
            get { return trndChtTranByDate; }
            set { trndChtTranByDate = value; }
        }

        private void btnGenRptsClick(object sender, EventArgs e)
        {
            controller.LoadRpts();
        }
    }
}
