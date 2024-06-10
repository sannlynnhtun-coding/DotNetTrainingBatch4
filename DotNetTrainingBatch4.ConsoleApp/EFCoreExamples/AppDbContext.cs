using DotNetTrainingBatch4.ConsoleApp.Dtos;
using DotNetTrainingBatch4.ConsoleApp.Services;
using Microsoft.EntityFrameworkCore;

namespace DotNetTrainingBatch4.ConsoleApp.EFCoreExamples;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder.UseSqlServer(ConnectionStrings.SqlConnectionStringBuilder.ConnectionString);
    //}

    public DbSet<BlogDto> Blogs { get; set; }
}
