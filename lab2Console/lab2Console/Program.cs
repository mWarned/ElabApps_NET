using System;
using System.Data.SqlClient;
using System.Xml.Serialization;

class Program
{
    static void Main()
    {
        string connectionString = "Server=YourServerName;Database=YourDatabaseName;Integrated Security=True;";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string query = "SELECT * FROM profesor";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["nmprofesor"]}");
                    }
                }
            }
        }

        Console.ReadLine();
    }
}
