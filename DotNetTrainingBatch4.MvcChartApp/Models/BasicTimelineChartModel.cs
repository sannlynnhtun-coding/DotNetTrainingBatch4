namespace DotNetTrainingBatch4.MvcChartApp.Models
{
    public class BasicTimelineChartModel
    {
        public List<TaskName> Data { get; set; }
    }

    public class TaskName
    {
        public string x { get; set; }
        public DateTime[] y { get; set; }
    }
}
