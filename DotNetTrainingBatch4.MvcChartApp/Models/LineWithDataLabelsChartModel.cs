namespace DotNetTrainingBatch4.MvcChartApp.Models
{
    public class LineWithDataLabelsChartModel
    {
        public string Name { get; set; }
        public List<int> dataList { get; set; }
    }
    public class LineWithDataLabelsChartRespondModel
    {
        public LineWithDataLabelsChartModel FirstRecord{ get; set; }
        public LineWithDataLabelsChartModel SecondRecord { get; set; }
    }
}
