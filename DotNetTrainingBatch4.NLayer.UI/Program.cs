// See https://aka.ms/new-console-template for more information

using DotNetTrainingBatch4.NLayer.BusinessLogic.Services;
using DotNetTrainingBatch4.NLayer.DataAccess.Models;
using Newtonsoft.Json;

Console.WriteLine("Hello, World!");

BL_Blog bL_Blog = new BL_Blog();
var lst = bL_Blog.GetBlogs();
Console.WriteLine(lst);

List<BlogEntity> blogEntities = lst.Select(x =>
        new BlogEntity(x.BlogId, x.BlogTitle!, x.BlogAuthor!, x.BlogContent!))
    .ToList();

var jsonStr = JsonConvert.SerializeObject(lst, Formatting.Indented);
Console.WriteLine(jsonStr);
Console.WriteLine(blogEntities.ToString());
foreach (var blogEntity in blogEntities)
{
    Console.WriteLine(blogEntity);
}
foreach (var item in lst)
{
    Console.WriteLine(item);
}
Console.ReadLine();