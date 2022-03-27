using Dapper;
using lab3;
using System.Data.SqlClient;

var connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" +
 "Integrated Security=True;Connect Timeout=30;Encrypt=False; " +
 "TrustServerCertificate=False;ApplicationIntent=ReadWrite; " +
 "MultiSubnetFailover=False";

var conn = new SqlConnection(connectionString);


var joinResult = conn.Query<Product, Category, Product>("SELECT * FROM Products p " +
    "JOIN Categories c on p.CategoryID = c.CategoryID",
    (product, category) =>
    {
        product.Category = category;
        return product;

    },
    splitOn:"CategoryId");

foreach (var item in joinResult)
{
    Console.WriteLine($"{item.ProductName}:{item.Category.CategoryName}");
}