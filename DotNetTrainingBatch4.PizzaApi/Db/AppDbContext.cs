using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetTrainingBatch4.PizzaApi.Db;

internal class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConnectionStrings.SqlConnectionStringBuilder.ConnectionString);
    }

    public DbSet<PizzaModel> Pizzas { get; set; }
    public DbSet<PizzaExtraModel> PizzaExtras { get; set; }
    public DbSet<PizzaOrderModel> PizzaOrders { get; set; }
    public DbSet<PizzaOrderDetailModel> PizzaOrderDetails { get; set; }
}

[Table("Tbl_Pizza")]
public class PizzaModel
{
    [Key]
    [Column("PizzaId")]
    public int Id { get; set; }
    [Column("Pizza")]
    public string Name { get; set; }
    [Column("Price")]
    public decimal Price { get; set; }
}

[Table("Tbl_PizzaExtra")]
public class PizzaExtraModel
{
    [Key]
    [Column("PizzaExtraId")]
    public int Id { get; set; }
    [Column("PizzaExtraName")]
    public string Name { get; set; }
    [Column("Price")]
    public decimal Price { get; set; }
    [NotMapped]
    public string PriceStr { get { return "$ " + Price; } }
}

public class OrderRequest
{
    public int PizzaId { get; set; }
    public int[] Extras { get; set; }
}

public class OrderResponse
{
    public string Message { get; set; }
    public string InvoiceNo { get; set; }
    public decimal TotalAmount { get; set; }
}

[Table("Tbl_PizzaOrder")]
public class PizzaOrderModel
{
    [Key]
    public int PizzaOrderId { get; set; }
    public string PizzaOrderInvoiceNo { get; set; }
    public int PizzaId { get; set; }
    public decimal TotalAmount { get; set; }
}

[Table("Tbl_PizzaOrderDetail")]
public class PizzaOrderDetailModel
{
    [Key]
    public int PizzaOrderDetailId { get; set; }
    public string PizzaOrderInvoiceNo { get; set; }
    public int PizzaExtraId { get; set; }
}