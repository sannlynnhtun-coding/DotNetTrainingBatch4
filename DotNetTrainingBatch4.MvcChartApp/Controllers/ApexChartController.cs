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

        public IActionResult StackedBar()
        {
            var seriesData = new List<SeriesData>
            {
                new SeriesData { name = "Marine Sprite", data = new List<int> { 44, 55, 41, 37, 22, 43, 21 } },
                new SeriesData { name = "Striking Calf", data = new List<int> { 53, 32, 33, 52, 13, 43, 32 } },
                new SeriesData { name = "Tank Picture", data = new List<int> { 12, 17, 11, 9, 15, 11, 20 } },
                new SeriesData { name = "Bucket Slope", data = new List<int> { 9, 7, 5, 8, 6, 9, 4 } },
                new SeriesData { name = "Reborn Kid", data = new List<int> { 25, 12, 19, 32, 25, 24, 10 } }
            };

            var model = new BarChartModel
            {
                Series = seriesData,
                Categories = new List<int> { 2008, 2009, 2010, 2011, 2012, 2013, 2014 }
            };

            return View(model);
        }
    }
}
