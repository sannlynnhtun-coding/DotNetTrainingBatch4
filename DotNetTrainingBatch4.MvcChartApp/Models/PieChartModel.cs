namespace DotNetTrainingBatch4.MvcChartApp.Models
{
    public class PieChartModel
    {
        public List<int> Series { get; set; }
        public List<string> Lables { get; set; }
    }

    public class SPLineChartModel
    {
        public List<int> Series1 { get; set; }
        public List<int> Series2 { get; set; }
        public List<string> Categories { get; set; }
    }
   
    public class PolarAreaChartModel
    {
        public List<int> Series { get; set; }
    }
}
