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

        public IActionResult StackedColumns()
        {
            StackedColumnModel model = new StackedColumnModel();
            model.Series = new List<Series>()
            {
                new Series
                {
                    Name = "Product A",
                    Data = new List<int> { 44, 55, 41, 67, 22, 43 }
                },
                new Series
                {
                    Name = "Product B",
                    Data = new List<int> { 13, 23, 20, 8, 13, 27 }
                },
                new Series
                {
                    Name = "Product C",
                    Data = new List<int> { 11, 17, 15, 15, 21, 14 }
                }
            };
            model.Categories = new List<string>() { "01/01/2011 GMT", "01/02/2011 GMT", "01/03/2011 GMT", "01/04/2011 GMT",
                    "01/05/2011 GMT", "01/06/2011 GMT"};

            return View(model);
        }
    }
}
