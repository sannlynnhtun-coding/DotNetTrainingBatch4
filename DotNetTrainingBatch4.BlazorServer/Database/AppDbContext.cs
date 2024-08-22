using DotNetTrainingBatch4.BlazorServer.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetTrainingBatch4.BlazorServer.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<BlogModel> Blogs { get; set; }
    }
}
