using System.Data.SqlClient;

string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" +
 "Integrated Security=True;Connect Timeout=30;Encrypt=False; " +
 "TrustServerCertificate=False;ApplicationIntent=ReadWrite; " +
 "MultiSubnetFailover=False";

string getQueryString = "SELECT * FROM dbo.Categories";

string Name = "Something";
SqlParameter[] sp = new SqlParameter[] { };



string insertString = " INSERT INTO dbo.Categories (CategoryName," +
    "Description) Values (@Name,@Description) ";


using (SqlConnection connection =
    new SqlConnection(connectionString))
{
    SqlCommand commandRead = new SqlCommand(getQueryString, connection);

    SqlCommand commandInsert = new SqlCommand(insertString, connection);

    try
    {
        connection.Open();
        Int32 recordsAffected = commandInsert.ExecuteNonQuery();
        SqlDataReader reader = commandRead.ExecuteReader();
        while (reader.Read())
        {
            Console.WriteLine("\t{0}\t{1}\t{2}",
                reader[0], reader[1], reader[2]);
        }
        reader.Close();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    Console.ReadLine();
}

