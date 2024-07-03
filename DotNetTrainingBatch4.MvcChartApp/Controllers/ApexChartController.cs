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

        public IActionResult CustomDataLabelsBarChart()
        {
            CustomDataLabelsBarChartModel model = new CustomDataLabelsBarChartModel();
            model.Data = new List<int> { 400, 430, 448, 470, 540, 580, 690, 1100, 1200, 1380 };
            model.Colors = new List<string>
            {
                "#33b2df", "#546E7A", "#d4526e", "#13d8aa", "#A5978B", "#2b908f", "#f9a3a4", "#90ee7e",
            "#f48024", "#69d2e7"
            };
            model.Categories = new List<string>
            {
                "South Korea", "Canada", "United Kingdom", "Netherlands", "Italy", "France", "Japan",
            "United States", "China", "India"
            };
            return View(model);
        }

    }
}
