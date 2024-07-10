namespace DotNetTrainingBatch4.MvcChartApp.Models
{
    public class BoxPlotDataPoint
    {
        public string x { get; set; }
        public List<int> y { get; set; }
    }

    public class BoxPlotChartModel
    {
        public List<BoxPlotDataPoint> Data { get; set; }
    }
}
