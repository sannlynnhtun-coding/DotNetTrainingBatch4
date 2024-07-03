using System;
namespace DotNetTrainingBatch4.MvcChartApp.Models;

public class BarChartModel
{
    public List<SeriesData> Series { get; set; }
    public List<int> Categories { get; set; }
}

public class SeriesData
{
    public string name { get; set; }
    public List<int> data { get; set; }
}

public class BarChartModel
{
    public List<int> Series { get; set; }
    public List<string> Labels { get; set; }
}
