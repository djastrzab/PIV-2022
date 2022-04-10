using System.Data.SqlClient;

string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" +
 "Integrated Security=True;Connect Timeout=30;Encrypt=False; " +
 "TrustServerCertificate=False;ApplicationIntent=ReadWrite; " +
 "MultiSubnetFailover=False";

string getQueryString = "SELECT * FROM dbo.Categories";
string Name = "Something2";
string Desc = "Desc2";

SqlParameter SqlName = new System.Data.SqlClient.SqlParameter("Name", Name);
SqlParameter SqlDesc = new System.Data.SqlClient.SqlParameter("Desc", Desc);


string insertString = " INSERT INTO dbo.Categories (CategoryName," +
    "Description) Values (@Name,@Desc) ";


using (SqlConnection connection =
    new SqlConnection(connectionString))
{
    SqlCommand commandRead = new SqlCommand(getQueryString, connection);

    SqlCommand commandInsert = new SqlCommand(insertString, connection);
    commandInsert.Parameters.Add(SqlName);
    commandInsert.Parameters.Add(SqlDesc);

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

