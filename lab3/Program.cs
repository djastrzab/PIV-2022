using Dapper;﻿
using System.Data.SqlClient;

var connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" +
 "Integrated Security=True;Connect Timeout=30;Encrypt=False; " +
 "TrustServerCertificate=False;ApplicationIntent=ReadWrite; " +
 "MultiSubnetFailover=False";

var conn = new SqlConnection(connectionString);
var result=conn.Query<lab3.Region>("SELECT * FROM Region");

foreach (var item in result)
{
       Console.WriteLine($"{item.RegionId}: {item.RegionDescription}");
}


