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

        public IActionResult PolarAreaChart() 
        { 
            PolarAreaChartModel polarAreaChartModel = new PolarAreaChartModel();
            polarAreaChartModel.Series = new List<int> { 14, 23, 21, 17, 15, 10, 12, 17, 21 };

            return View(polarAreaChartModel);
        }
    }
}
