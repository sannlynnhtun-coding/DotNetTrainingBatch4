using Newtonsoft.Json;

namespace DotNetTrainingBatch4.MvcChartApp.Models;

public class LineColumnAreaModel
{
    public List<LineColumnAreaSeriesModel> Series { get; set; }
    public List<DateOnly> Labels { get; set; }
}

public class LineColumnAreaSeriesModel
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("data")]
    public List<int> Data { get; set; }
}