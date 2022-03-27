using Dapper;
using lab3;
using System.Data.SqlClient;

var connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" +
 "Integrated Security=True;Connect Timeout=30;Encrypt=False; " +
 "TrustServerCertificate=False;ApplicationIntent=ReadWrite; " +
 "MultiSubnetFailover=False";

var conn = new SqlConnection(connectionString);

var regionToInsert = new Region()
{
    RegionId = 6,
    RegionDescription = "test2"
};

var insertResult = conn.Execute(
    "INSERT INTO Region (RegionID , RegionDescription) VALUES (@Id, @Description)",
    regionToInsert);

var result = conn.Query<Region>("SELECT * FROM Region");

foreach (var item in result)
{
    Console.WriteLine($"{item.RegionId}: {item.RegionDescription}");
}
