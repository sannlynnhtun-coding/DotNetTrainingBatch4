namespace DotNetTrainingBatch4.MvcChartApp.Models
{
    public class StackedBarChartModel
    {
        public List<StackedBarSeries> Series { get; set; }
        public List<int> Categories { get; set; }
    }

    public class StackedBarSeries
    {
        public string name { get; set; }
        public List<int> data { get; set; }
    }
}
