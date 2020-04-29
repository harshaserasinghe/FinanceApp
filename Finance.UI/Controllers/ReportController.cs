using Finance.Core.DTOs;
using Finance.Core.Entities;
using Finance.Service;
using Finance.UI.Views;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Finance.UI.Controllers
{
    public class ReportController
    {
        private readonly ReportService rptService;
        private readonly UserService userService;
        private readonly UserDto loggedUser;
        private ReportView view;
        private Func<ChartPoint, string> expnBrkDwnByContLabelPoint;
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
            InitTranSumryRpt();
            InitExpnBrkDwnByContRpt();
            InitTranByDateRpt();
        }
        public void Show()
        {
            view.Show();
        }

        private void InitTranSumryRpt()
        {
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

        private void InitExpnBrkDwnByContRpt()
        {
            expnBrkDwnByContLabelPoint = chartPoint => string.Format("{0:P}", chartPoint.Participation);
            view.ContExpBrkDwn.LegendLocation = LegendLocation.Right;
        }

        private void InitTranByDateRpt()
        {
            view.TranByDate.AxisX.Add(new Axis
            {
                Title = "Transaction Date",
                MinValue = 0,
                Separator = new Separator { Step = 1 },
                Labels = new List<string>(),
            });

            view.TranByDate.AxisY.Add(new Axis
            {
                Title = "Amount",
                MinValue = 0,
                Separator = new Separator { Step = 10000 },
            });

            view.TranByDate.LegendLocation = LegendLocation.Right;
        }

        public void LoadRpts()
        {
            LoadTranSumryRpt();
            LoadExpBrkDwnByContRpt();
            LoadTranByDateRpt();
        }

        private void LoadTranSumryRpt()
        {
            view.TranSum.Series.Clear();
            var tranSumryDtos = rptService.GetTranSumry(
                loggedUser.UserId, view.FromDate.Value, view.ToDate.Value);
            var seriColl = new SeriesCollection();

            foreach (var tranSumryDto in tranSumryDtos)
            {
                var colSeri = new ColumnSeries
                {
                    Title = tranSumryDto.TranType.ToString(),
                    Values = new ChartValues<decimal> { tranSumryDto.TotalAmount }
                };
                seriColl.Add(colSeri);
            }

            view.TranSum.Series = seriColl;
        }

        private void LoadExpBrkDwnByContRpt()
        {
            view.ContExpBrkDwn.Series.Clear();
            var expnByContDtos = rptService.GetExpnBrkDwnByCont(
                loggedUser.UserId, view.FromDate.Value, view.ToDate.Value);
            var seriColl = new SeriesCollection();

            foreach (var expnByContDto in expnByContDtos)
            {
                var pieSeri = new PieSeries
                {
                    Title = expnByContDto.Name,
                    Values = new ChartValues<decimal> { expnByContDto.TotalAmount },
                    DataLabels = true,
                    LabelPoint = expnBrkDwnByContLabelPoint
                };
                seriColl.Add(pieSeri);
            }

            view.ContExpBrkDwn.Series = seriColl;
        }

        private void LoadTranByDateRpt()
        {
            view.TranByDate.AxisX[0].Labels.Clear();
            view.TranByDate.Series.Clear();
            var tranByDateDtos = rptService.GetTranBrkDownByDate(
                loggedUser.UserId, view.FromDate.Value, view.ToDate.Value);
            var seriColl = new SeriesCollection();

            var debitSeri = new LineSeries
            {
                Title = TranType.Debit.ToString(),
                Values = new ChartValues<decimal>(),
            };

            var creditSeri = new LineSeries
            {
                Title = TranType.Credit.ToString(),
                Values = new ChartValues<decimal>(),
            };

            foreach (var tranByDateDto in tranByDateDtos)
            {

                if (tranByDateDto.TranType == TranType.Debit)
                {
                    debitSeri.Values.Add(tranByDateDto.TotalAmount);
                }

                if (tranByDateDto.TranType == TranType.Credit)
                {
                    creditSeri.Values.Add(tranByDateDto.TotalAmount);
                }

                var tranDate = tranByDateDto.TranDate.ToString("dd/MM");

                if (!view.TranByDate.AxisX[0].Labels.Any(l => l == tranDate))
                {
                    view.TranByDate.AxisX[0].Labels.Add(tranDate);
                }
            }

            seriColl.Add(creditSeri);
            seriColl.Add(debitSeri);
            view.TranByDate.Series = seriColl;
        }
    }
}
