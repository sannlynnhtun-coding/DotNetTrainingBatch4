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

        public IActionResult BasicColumnChart()
        {
            ColumnChartModel model = new ColumnChartModel();
            model.Series = new List<Series>
            {
                new Series { Name = "Net Profit", Data = new List<int> { 44, 55, 57, 56, 61, 58, 63, 60, 66 } },
                new Series { Name = "Revenue", Data = new List<int> { 76, 85, 101, 98, 87, 105, 91, 114, 94 } },
                new Series { Name = "Free Cash Flow", Data = new List<int> { 35, 41, 36, 26, 45, 48, 52, 53, 41 } }
            };
            model.Categories = new List<string> { "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct" };

            return View(model);
        }
    }
}
