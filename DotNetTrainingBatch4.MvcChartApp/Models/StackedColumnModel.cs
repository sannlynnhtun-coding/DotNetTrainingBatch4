namespace DotNetTrainingBatch4.MvcChartApp.Models;

public class StackedColumnModel
{
    public List<Series> Series { get; set; }
    public List<string> Categories { get; set; }
}

public class Series
{
    public string Name { get; set; }
    public List<int> Data { get; set; }
}
