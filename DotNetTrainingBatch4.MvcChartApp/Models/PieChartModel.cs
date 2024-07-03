namespace DotNetTrainingBatch4.MvcChartApp.Models
{
    public class PieChartModel
    {
        public List<int> Series { get; set; }
        public List<string> Lables { get; set; }
    }

    public class PolarAreaChartModel
    {
        public List<int> Series { get; set; }
    }
}
