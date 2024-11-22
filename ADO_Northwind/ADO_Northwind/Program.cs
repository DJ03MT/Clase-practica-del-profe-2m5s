using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.CodeDom;


namespace ADO_Northwind
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=Tuservidor; Database = Northwind; Trusted_Connection = True; TrustServerCertificate = True; ";
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.Open();
                    Console.WriteLine("Conexion existosa.");
            }
            catch (Exception ex) {
                Console.WriteLine($"Error: {ex.Message} ");
            }

        }
    }
}
