namespace DotNetTrainingBatch4.MvcChartApp.Models
{
    public class BasicSlopeChartModel
    {
        public List<string> Categories { get; set; }
        public List<SeriesData> Series { get; set; }
    }

    public class SeriesData
    {
        public string Name { get; set; }
        public List<DataPoint> Data { get; set; }
    }

    public class DataPoint
    {
        public string Jan { get; set; }
        public int Feb { get; set; }
    }
}
