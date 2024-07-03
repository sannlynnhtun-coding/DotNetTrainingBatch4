namespace DotNetTrainingBatch4.MvcChartApp.Models;

public class GroupBarModel
{
    public List<GroupBar> BarGroup { get; set; }
    public List<int> Categories { get; set; }
}

public class GroupBar
{
    public List<int> data { get; set; }
}
