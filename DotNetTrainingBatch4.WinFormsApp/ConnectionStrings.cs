using System.Data.SqlClient;

namespace DotNetTrainingBatch4.WinFormsApp;

internal static class ConnectionStrings
{
    public static SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
    {
        DataSource = ".",
        InitialCatalog = "DotNetTrainingBatch4",
        // InitialCatalog = "TestDb",
        UserID = "sa",
        Password = "sasa@123",
        TrustServerCertificate = true
    };
}