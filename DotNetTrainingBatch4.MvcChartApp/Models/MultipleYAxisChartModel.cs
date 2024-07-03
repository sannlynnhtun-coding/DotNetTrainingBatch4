namespace DotNetTrainingBatch4.MvcChartApp.Models
{
    public class MultipleYAxisChartModel
    {
        public List<ListOfSeries>? Series { get; set; }
        public List<int>? Categories { get; set; }
    }

    public class ListOfSeries 
    {
        public string? name { get; set; }
        public string? type { get; set; }
        public List<double>? data { get; set; }
    }
    
}
