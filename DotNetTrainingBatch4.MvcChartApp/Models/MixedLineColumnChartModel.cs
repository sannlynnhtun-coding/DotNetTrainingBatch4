namespace DotNetTrainingBatch4.MvcChartApp.Models
{
    public class MixedLineColumnChartModel
    {
        public string Title { get; set; }
        public List<LineColumnChartSerie> Series { get; set; }
        public List<string> Labels { get; set; }
    }

    public class LineColumnChartSerie
    {
        public string? name { get; set; }
        public string? type { get; set; }
        public List<int> data { get; set; }
    }
}
