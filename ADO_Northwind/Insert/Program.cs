using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;

namespace Insert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=Tuservidor; Database = Northwind; Trusted_Connection = True; TrustServerCertificate = True; ";
            SqlCommand command = new SqlCommand(connectionString);
            string insertQuery = "INSERT INTO (ProductName, UnitPrice, UnitsInStock)Values (@ProductName,@UnitPrice, @UnitsInStock)";
            SqlConnection connection = new SqlConnection(connectionString);
            command.Parameters.AddWithValue("@ProductName", "New Product");
            command.Parameters.AddWithValue("@UnitPrice", 15.00);
            command.Parameters.AddWithValue("@UnitsInStock", 50);
            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} fila(s) insertada(s).");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
