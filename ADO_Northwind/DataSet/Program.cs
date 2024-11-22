using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=Tuservidor; Database = Northwind; Trusted_Connection = True; TrustServerCertificate = True; ";
            SqlConnection connection = new SqlConnection(connectionString);
            DataSet dataSet = new DataSet();
            string Query = "SELECT * FROM Products; SELECT * FROM Categories;";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, connection);

            adapter.Fill(dataSet);

            DataTable productsTable = dataSet.Tables[0];
            DataTable categoriesTable = dataSet.Tables[1];

            foreach (DataRow row in productsTable.Rows)
            {
                Console.WriteLine($"ID: {row["ProductID"]}, Nombre: {row["ProductName"]}");
            }
        }
    }
}
