namespace DotNetTrainingBatch4.MvcChartApp.Models;


public class StackedColumnModel
{
    public List<Group> Series { get; set; }
    public List<string> Categories { get; set; }
}

public class Group
{
    public string Name { get; set; }
    public List<int> Data { get; set; }
}
