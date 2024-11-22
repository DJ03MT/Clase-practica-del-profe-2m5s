using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consulta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=Tuservidor; Database = Northwind; Trusted_Connection = True; TrustServerCertificate = True; ";
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT ProductID, ProductName, UnitPrice FROM Products";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                Console.WriteLine("ProductID\tProductName\t\tUnitPrice");
                while (reader.Read())
                {
                    Console.WriteLine($"{reader["ProductID"]}\t{reader["ProductName"]}\t{reader["UnitPrice"]}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message} ");
            }
        }
    }
}
