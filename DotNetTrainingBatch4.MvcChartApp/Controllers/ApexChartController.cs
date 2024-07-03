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

        public IActionResult MultiSeriesTimelineChart()
        {
            var responseList = new List<MultiSeriesTimelineChartModel>
        {
            new()
            {
                Name = "Bob",
                Timelines = new List<Timelines>
                {
                    new () { Title = "Design", DateTimes = new List<DateTime> { new (2019, 3, 5), new DateTime(2019, 3, 8) } },
                    new () { Title = "Code", DateTimes = new List<DateTime> { new (2019, 3, 8), new DateTime(2019, 3, 11) } },
                    new () { Title = "Test", DateTimes = new List<DateTime> { new (2019, 3, 11), new DateTime(2019, 3, 16) } }
                }
            },
            new() {
                Name = "Joe",
                Timelines = new List<Timelines>
                {
                    new () { Title = "Design", DateTimes = new List<DateTime> { new (2019, 3, 2), new DateTime(2019, 3, 5) } },
                    new () { Title = "Code", DateTimes = new List<DateTime> { new (2019, 3, 6), new DateTime(2019, 3, 9) } },
                    new () { Title = "Test", DateTimes = new List<DateTime> { new (2019, 3, 10), new DateTime(2019, 3, 19) } }
                }
            }
        };
            return View(responseList);
        }
    }
}
