using DotNetTrainingBatch4.ConsoleApp.AdoDotNetExamples;
using DotNetTrainingBatch4.ConsoleApp.DapperExamples;
using DotNetTrainingBatch4.ConsoleApp.EFCoreExamples;
using DotNetTrainingBatch4.ConsoleApp.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");

// npm
// pub.dev
// nuget
//SqlConnection

// Ctrl + . => suggestion
// F10 => 
// F11
// F9 => Breakpoint

// => C# => Db

//SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
//stringBuilder.DataSource = "."; // server name
//stringBuilder.InitialCatalog = "DotNetTrainingBatch4"; // database name
//stringBuilder.UserID = "sa";
//stringBuilder.Password = "sasa@123";
//SqlConnection connection = new SqlConnection(stringBuilder.ConnectionString);
////SqlConnection connection = new SqlConnection("Data Source=USER;Initial Catalog=DotNetTrainingBatch4;User ID=sa;Password=sasa@123");

//connection.Open();
//Console.WriteLine("Connection open.");

//string query = "select * from tbl_blog";
//SqlCommand cmd = new SqlCommand(query, connection);
//SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
//DataTable dt = new DataTable();
//sqlDataAdapter.Fill(dt);

//connection.Close();
//Console.WriteLine("Connection close.");

//// dataset => datatable
//// datatable => datarow
//// datarow => datacolumn

//foreach (DataRow dr in dt.Rows)
//{
//    Console.WriteLine("Blog Id => " + dr["BlogId"]);
//    Console.WriteLine("Blog Tilte => " + dr["BlogTitle"]);
//    Console.WriteLine("Blog Author => " + dr["BlogAuthor"]);
//    Console.WriteLine("Blog Content => " + dr["BlogContent"]);
//    Console.WriteLine("--------------------------------");
//}


// Ado.Net Read
// CRUD

//AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
////adoDotNetExample.Read();
////adoDotNetExample.Create("title", "author", "content");
////adoDotNetExample.Update(1003, "title 1", "author 1", "content 1");
////adoDotNetExample.Delete(1003);
////adoDotNetExample.Update(1002, "test title", "test author", "test content");
////adoDotNetExample.Delete(1002);
//adoDotNetExample.Edit("1002 or 1=1");
//adoDotNetExample.Edit(1);

//DapperExample dapperExample = new DapperExample();
//dapperExample.Run();

//EFCoreExample eFCoreExample = new EFCoreExample();
//eFCoreExample.Run();

//try
//{

//}
//catch (Exception ex)
//{

//	throw;
//}
//finally
//{

//}
var connectionString = ConnectionStrings.SqlConnectionStringBuilder.ConnectionString;
var sqlConnectionStringBuilder = new SqlConnectionStringBuilder(connectionString);

var serviceProvider = new ServiceCollection()
    .AddScoped(n => new AdoDotNetExample(sqlConnectionStringBuilder))
    .AddScoped(n => new DapperExample(sqlConnectionStringBuilder))
    .AddDbContext<AppDbContext>(opt =>
    {
        opt.UseSqlServer(connectionString);
    })
    .AddScoped<EFCoreExample>()
    .BuildServiceProvider();

//AppDbContext db = serviceProvider.GetRequiredService<AppDbContext>();

var adoDotNetExample = serviceProvider.GetRequiredService<AdoDotNetExample>();
adoDotNetExample.Read();

//var dapperExample = serviceProvider.GetRequiredService<DapperExample>();
//dapperExample.Run();

Console.ReadLine();