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

        public IActionResult MixedLineColumnChart()
        {
            MixedLineColumnChartModel model = new MixedLineColumnChartModel();
            model.Title = "Traffic Sources";
            model.Series = new List<Serie>();

            Serie column = new Serie
            {
                name = "Website Blog",
                type = "column",
                data = new List<int> { 440, 505, 414, 671, 227, 413, 201, 352, 752, 320, 257, 160 }
            };

            Serie line = new Serie
            {
                name = "Social Media",
                type = "line",
                data = new List<int> { 23, 42, 35, 27, 43, 22, 17, 31, 22, 22, 12, 16 }
            };

            model.Series.Add(column);
            model.Series.Add(line);

            model.Labels = new List<string>()
            {
                "01 June 2024",
                "02 June 2024",
                "03 June 2024",
                "04 June 2024",
                "05 June 2024",
                "06 June 2024",
                "07 June 2024",
                "08 June 2024",
                "09 June 2024",
                "10 June 2024",
                "11 June 2024",
                "12 June 2024"
            };

            return View(model);
        }
    }
}
