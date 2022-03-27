using Dapper;
using lab3;
using System.Data.SqlClient;

var connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" +
 "Integrated Security=True;Connect Timeout=30;Encrypt=False; " +
 "TrustServerCertificate=False;ApplicationIntent=ReadWrite; " +
 "MultiSubnetFailover=False";

var conn = new SqlConnection(connectionString);



var insertResult = conn.Execute(
    "INSERT INTO Region (RegionID , RegionDescription) VALUES (@RegionId, @RegionDescription)",
    new
    {
        RegionId=7,
        RegionDescription="test3"
    }
    );

var result = conn.Query<Region>("SELECT * FROM Region");

foreach (var item in result)
{
    Console.WriteLine($"{item.RegionId}: {item.RegionDescription}");
}
