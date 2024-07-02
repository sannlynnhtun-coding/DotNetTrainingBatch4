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
        public IActionResult BasicSlopeChart()
        {
            BasicSlopeChartModel model = new BasicSlopeChartModel
            {
                Categories = new List<string> { "Jan", "Feb" },
                Series = new List<SeriesData>
                {
                    new SeriesData
                    {
                        Name = "Blue",
                        Data = new List<DataPoint>
                        {
                            new DataPoint { Jan = "Jan", Feb = 43 },
                            new DataPoint { Jan = "Feb", Feb = 58 }
                        }
                    },
                    new SeriesData
                    {
                        Name = "Green",
                        Data = new List<DataPoint>
                        {
                            new DataPoint { Jan = "Jan", Feb = 33 },
                            new DataPoint { Jan = "Feb", Feb = 38 }
                        }
                    },
                    new SeriesData
                    {
                        Name = "Red",
                        Data = new List<DataPoint>
                        {
                            new DataPoint { Jan = "Jan", Feb = 55 },
                            new DataPoint { Jan= "Feb", Feb = 21 }
                        }
                    }
                }
            };

            return View(model);
        }
    }
}
