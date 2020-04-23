using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.UI.Controllers
{
    public class ReportController
    {
        public ReportController()
        {
            //LoadTranSumChart();
            //LoadContExpChart();
            //LoadTranDetailsChart();
        }
        //public void LoadTranSumChart()
        //{
        //    var fromDate = new DateTime(2020, 03, 01);
        //    var toDate = new DateTime(2020, 03, 31);

        //    var tranSumDtos = tranService.GetTranSum(loggedUser.UserId, fromDate, toDate);

        //    var seriColl = new SeriesCollection();

        //    foreach (var tranSumDto in tranSumDtos)
        //    {
        //        var colSeri = new ColumnSeries
        //        {
        //            Title = tranSumDto.TranType.ToString(),
        //            Values = new ChartValues<decimal> { tranSumDto.TotalAmount }
        //        };
        //        seriColl.Add(colSeri);
        //    }

        //    view.TranSumChart.Series = seriColl;

        //    view.TranSumChart.AxisX.Add(new Axis
        //    {
        //        Title = "Transaction Types",
        //        Labels = new[] { string.Empty }
        //    });

        //    view.TranSumChart.AxisY.Add(new Axis
        //    {
        //        Title = "Amount",
        //        MinValue = 0,
        //        Separator = new Separator { Step = 50000 }
        //    });

        //    view.TranSumChart.LegendLocation = LegendLocation.Left;
        //}

        //public void LoadContExpChart()
        //{
        //    var fromDate = new DateTime(2020, 03, 01);
        //    var toDate = new DateTime(2020, 03, 31);

        //    var contExpDtos = tranService.GetContExp(loggedUser.UserId, fromDate, toDate);

        //    Func<ChartPoint, string> labelPoint = chartPoint =>
        //        string.Format("{0:P}", chartPoint.Participation);

        //    var seriColl = new SeriesCollection();

        //    foreach (var contExpDto in contExpDtos)
        //    {
        //        var pieSeri = new PieSeries
        //        {
        //            Title = contExpDto.Name,
        //            Values = new ChartValues<decimal> { contExpDto.TotalAmount },
        //            DataLabels = true,
        //            LabelPoint = labelPoint
        //        };
        //        seriColl.Add(pieSeri);
        //    }

        //    view.ContExpChart.Series = seriColl;
        //    view.ContExpChart.LegendLocation = LegendLocation.Right;
        //}

        //public void LoadTranDetailsChart()
        //{
        //    var fromDate = new DateTime(2020, 03, 01);
        //    var toDate = new DateTime(2020, 03, 31);

        //    var tranDetailDtos = tranService.GetTranDetail(loggedUser.UserId, fromDate, toDate);

        //    var seriColl = new SeriesCollection();

        //    var xAxis = new Axis
        //    {
        //        Title = "Transaction Date",
        //        MinValue = 0,
        //        Separator = new Separator { Step = 1 },
        //        Labels = new List<string>()
        //    };

        //    var yAxis = new Axis
        //    {
        //        Title = "Amount",
        //        MinValue = 0,
        //        Separator = new Separator { Step = 10000 }
        //    };

        //    var debtSeri = new LineSeries
        //    {
        //        Title = TranType.Debet.ToString(),
        //        Values = new ChartValues<decimal>()
        //    };

        //    var creditSeri = new LineSeries
        //    {
        //        Title = TranType.Credit.ToString(),
        //        Values = new ChartValues<decimal>()
        //    };

        //    foreach (var tranDetailDto in tranDetailDtos)
        //    {

        //        if (tranDetailDto.TranType == TranType.Debet)
        //        {
        //            debtSeri.Values.Add(tranDetailDto.TotalAmount);
        //        }

        //        if (tranDetailDto.TranType == TranType.Credit)
        //        {
        //            creditSeri.Values.Add(tranDetailDto.TotalAmount);
        //        }

        //        var tranDate = tranDetailDto.TranDate.ToShortDateString();
        //        if (!xAxis.Labels.Any(l => l == tranDate))
        //        {
        //            xAxis.Labels.Add(tranDate);
        //        }
        //    }

        //    seriColl.Add(debtSeri);
        //    seriColl.Add(creditSeri);

        //    view.TranDetailChart.Series = seriColl;
        //    view.TranDetailChart.AxisX.Add(xAxis);
        //    view.TranDetailChart.AxisY.Add(yAxis);

        //    view.TranDetailChart.LegendLocation = LegendLocation.Right;
        //}
    }
}
