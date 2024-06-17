using DotNetTrainingBatch4.MinimalApi.Models;
using Microsoft.EntityFrameworkCore;
namespace DotNetTrainingBatch4.MinimalApi.Db;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder.UseSqlServer(ConnectionStrings.SqlConnectionStringBuilder.ConnectionString);
    //}

    public DbSet<BlogModel> Blogs { get; set; }
}