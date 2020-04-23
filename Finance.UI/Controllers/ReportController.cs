using Finance.Core.DTOs;
using Finance.Core.Entities;
using Finance.Service;
using Finance.UI.Views;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.UI.Controllers
{
    public class ReportController
    {
        private readonly ReportService rptService;
        private readonly UserService userService;
        private readonly UserDto loggedUser;
        private ReportView view;
        public ReportController(ReportView view)
        {
            this.view = view;
            this.view.SetController(this);
            rptService = new ReportService();
            userService = new UserService();
            loggedUser = userService.GetUser(Environment.UserName);
        }

        public void Init()
        {
            //GenRpts();
        }

        public void Show()
        {
            view.Show();
        }

        public void GenRpts()
        {
            var fromDate = view.FromDate.Value;
            var toDate = view.ToDate.Value;
            LoadTranSum(fromDate,toDate);
            LoadContExpBrkDwn(fromDate, toDate);
            LoadTranByDate(fromDate, toDate);
        }

        public void LoadTranSum(DateTime fromDate,DateTime toDate)
        {
            var tranSumDtos = rptService.GetTranSum(loggedUser.UserId, fromDate, toDate);

            var seriColl = new SeriesCollection();

            foreach (var tranSumDto in tranSumDtos)
            {
                var colSeri = new ColumnSeries
                {
                    Title = tranSumDto.TranType.ToString(),
                    Values = new ChartValues<decimal> { tranSumDto.TotalAmount }
                };
                seriColl.Add(colSeri);
            }

            view.TranSum.Series = seriColl;

            view.TranSum.AxisX.Add(new Axis
            {
                Title = "Transaction Types",
                Labels = new[] { string.Empty }
            });

            view.TranSum.AxisY.Add(new Axis
            {
                Title = "Amount",
                MinValue = 0,
                Separator = new Separator { Step = 50000 }
            });

            view.TranSum.LegendLocation = LegendLocation.Left;
        }

        public void LoadContExpBrkDwn(DateTime fromDate, DateTime toDate)
        {
            var contExpBrkDwnDtos = rptService.GetContExpBrkDwn(loggedUser.UserId, fromDate, toDate);

            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0:P}", chartPoint.Participation);

            var seriColl = new SeriesCollection();

            foreach (var contExpDto in contExpBrkDwnDtos)
            {
                var pieSeri = new PieSeries
                {
                    Title = contExpDto.Name,
                    Values = new ChartValues<decimal> { contExpDto.TotalAmount },
                    DataLabels = true,
                    LabelPoint = labelPoint
                };
                seriColl.Add(pieSeri);
            }

            view.ContExpBrkDwn.Series = seriColl;
            view.ContExpBrkDwn.LegendLocation = LegendLocation.Right;
        }

        public void LoadTranByDate(DateTime fromDate, DateTime toDate)
        {
            var tranByDateDtos = rptService.GetTranByDate(loggedUser.UserId, fromDate, toDate);

            var seriColl = new SeriesCollection();

            var xAxis = new Axis
            {
                Title = "Transaction Date",
                MinValue = 0,
                Separator = new Separator { Step = 1 },
                Labels = new List<string>()
            };

            var yAxis = new Axis
            {
                Title = "Amount",
                MinValue = 0,
                Separator = new Separator { Step = 10000 }
            };

            var debtSeri = new LineSeries
            {
                Title = TranType.Debet.ToString(),
                Values = new ChartValues<decimal>()
            };

            var creditSeri = new LineSeries
            {
                Title = TranType.Credit.ToString(),
                Values = new ChartValues<decimal>()
            };

            foreach (var tranDetailDto in tranByDateDtos)
            {

                if (tranDetailDto.TranType == TranType.Debet)
                {
                    debtSeri.Values.Add(tranDetailDto.TotalAmount);
                }

                if (tranDetailDto.TranType == TranType.Credit)
                {
                    creditSeri.Values.Add(tranDetailDto.TotalAmount);
                }

                var tranDate = tranDetailDto.TranDate.ToShortDateString();
                if (!xAxis.Labels.Any(l => l == tranDate))
                {
                    xAxis.Labels.Add(tranDate);
                }
            }

            seriColl.Add(debtSeri);
            seriColl.Add(creditSeri);

            view.TranByDate.Series = seriColl;
            view.TranByDate.AxisX.Add(xAxis);
            view.TranByDate.AxisY.Add(yAxis);

            view.TranByDate.LegendLocation = LegendLocation.Right;
        }
    }
}
