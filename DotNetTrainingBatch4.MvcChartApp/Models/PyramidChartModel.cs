namespace DotNetTrainingBatch4.MvcChartApp.Models
{
    public class PyramidChartModel
    {
        public List<PyramidChartSeriesData> Series { get; set; }
        public List<string> Colors { get; set; }
        public List<string> Categories { get; set; }
    }

    public class PyramidChartSeriesData
    {
        public string name { get; set; }
        public List<int> data { get; set; }
    }
}
