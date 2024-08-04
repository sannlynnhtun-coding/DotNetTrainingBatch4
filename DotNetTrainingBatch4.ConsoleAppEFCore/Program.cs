using DotNetTrainingBatch4.ConsoleAppEFCore.Databases.Models;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

AppDbContext db = new AppDbContext();
db.TblPieCharts.ToList();