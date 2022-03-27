using Dapper;
using lab3;
using System.Data.SqlClient;

var connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" +
 "Integrated Security=True;Connect Timeout=30;Encrypt=False; " +
 "TrustServerCertificate=False;ApplicationIntent=ReadWrite; " +
 "MultiSubnetFailover=False";

var conn = new SqlConnection(connectionString);


var result = conn.Query<Region>("SELECT * FROM Region");

foreach (var item in result)
{
    Console.WriteLine($"{item.RegionId}: {item.RegionDescription}");
}

var joinResult = conn.Query<Product, Category, Product>("SELECT * FROM Products p " +
    "JOIN Categories c on p.CategoryID = c.CategoryID",
    (product, category) =>
    {
        product.Category = category;
        return product;

    });

foreach (var item in joinResult)
{
    Console.WriteLine($"{item.ProductName}:{item.Category.CategoryName}");
}