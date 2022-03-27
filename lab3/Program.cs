using Dapper;
using lab3;
using System.Data.SqlClient;

var connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" +
 "Integrated Security=True;Connect Timeout=30;Encrypt=False; " +
 "TrustServerCertificate=False;ApplicationIntent=ReadWrite; " +
 "MultiSubnetFailover=False";

var conn = new SqlConnection(connectionString);


var joinResult = conn.Query<Territory, Region, Territory>("SELECT * FROM Territories t " +
    "JOIN Region r on t.RegionID = r.RegionID WHERE t.TerritoryDescription like 'p%'",
    (territory, region) =>
    {
        territory.Region = region;
        return territory;

    },
    splitOn:"RegionID");

foreach (var item in joinResult)
{
    Console.WriteLine($"{item.TerritoryDescription}:{item.Region.RegionDescription}");
}