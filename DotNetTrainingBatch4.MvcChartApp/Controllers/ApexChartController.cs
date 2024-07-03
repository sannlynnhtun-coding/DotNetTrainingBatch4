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

        [ActionName("Stepline")]
        public IActionResult SteplineChart()
        {
            SteplineChartModel model = new SteplineChartModel();
            model.Data = new List<int>() { 34, 44, 54, 21, 12, 43, 33, 23, 66, 66, 58 };
            return View("SteplineChart",model);
        }
    }
}
