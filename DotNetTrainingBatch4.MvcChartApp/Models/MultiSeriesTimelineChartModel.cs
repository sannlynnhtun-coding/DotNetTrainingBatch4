namespace DotNetTrainingBatch4.MvcChartApp.Models
{
    public class MultiSeriesTimelineChartModel
    {
        public string Name { get; set; }
        public List<Timelines> Timelines { get; set; }
    }

    public class Timelines
    {
        public string Title { get; set; }
        public List<DateTime> DateTimes { get; set; }
    }
}
