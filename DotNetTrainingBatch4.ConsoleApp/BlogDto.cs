using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTrainingBatch4.ConsoleApp;

public class BlogDto
{
    public int BlogId { get; set; }
    public string BlogTitle { get; set; }
    public string BlogAuthor { get; set; }
    public string BlogContent { get; set; }
}

//public record BlogEntity(int BlogId, string BlogTitle, string BlogAuthor, string BlogContent);
