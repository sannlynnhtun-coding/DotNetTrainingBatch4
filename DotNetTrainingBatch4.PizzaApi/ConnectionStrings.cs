using System.Data.SqlClient;

namespace DotNetTrainingBatch4.PizzaApi;

internal static class ConnectionStrings
{
    public static SqlConnectionStringBuilder SqlConnectionStringBuilder = new SqlConnectionStringBuilder()
    {
        DataSource = ".",
        InitialCatalog = "DotNetTrainingBatch4",
        // InitialCatalog = "TestDb",
        UserID = "sa",
        Password = "sasa@123",
        TrustServerCertificate = true
    };
}