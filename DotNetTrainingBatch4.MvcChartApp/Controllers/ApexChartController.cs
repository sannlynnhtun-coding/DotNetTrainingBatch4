using DotNetTrainingBatch4.MvcChartApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetTrainingBatch4.MvcChartApp.Controllers
{
    public class ApexChartController : Controller
    {
        public IActionResult SimplePieChart()
        {
            PieChartModel model = new PieChartModel();
            model.Lables = new List<string>() { "Team A", "Team B", "Team C", "Team D", "Team E" };
            model.Series = new List<int> { 44, 55, 13, 43, 22 };

            return View(model);
        }

        public IActionResult ColumnChartWithDataLables()
        {
            ColumnChartWithDataLablesModel model = new ColumnChartWithDataLablesModel();
            model.Categories = new List<string>()
            {
                "Jan",
                "Feb",
                "Mar",
                "Apr",
                "May",
                "Jun",
                "Jul",
                "Aug",
                "Sep",
                "Oct",
                "Nov",
                "Dec"
            };
            model.Inflation = new List<double>
            {
                2.3,
                3.1,
                4.0,
                10.1,
                4.0,
                3.6,
                3.2,
                2.3,
                1.4,
                0.8,
                0.5,
                0.2
            };
            return View(model);
        }
    }
}
