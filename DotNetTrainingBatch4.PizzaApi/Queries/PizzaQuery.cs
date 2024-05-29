namespace DotNetTrainingBatch4.PizzaApi.Queries;

public class PizzaQuery
{
    public static string PizzaOrderQuery { get; } = 
        @"select po.*, p.Pizza, p.Price from [dbo].[Tbl_PizzaOrder] po
            inner join Tbl_Pizza p on p.PizzaId = po.PizzaId
            where PizzaOrderInvoiceNo = @PizzaOrderInvoiceNo;
            ";

    public static string PizzaOrderDetailQuery { get; } =
        @"select pod.*, pe.PizzaExtraName, pe.Price from [dbo].[Tbl_PizzaOrderDetail] pod
            inner join Tbl_PizzaExtra pe on pod.PizzaExtraId = pe.PizzaExtraId
            where PizzaOrderInvoiceNo = @PizzaOrderInvoiceNo;";
}
