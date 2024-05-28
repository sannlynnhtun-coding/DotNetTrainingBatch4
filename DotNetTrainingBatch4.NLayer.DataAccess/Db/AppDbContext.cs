using Microsoft.EntityFrameworkCore;
using DotNetTrainingBatch4.NLayer.DataAccess.Models;

namespace DotNetTrainingBatch4.NLayer.DataAccess.Db;

internal class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConnectionStrings.SqlConnectionStringBuilder.ConnectionString);
    }

    public DbSet<BlogModel> Blogs { get; set; }
}