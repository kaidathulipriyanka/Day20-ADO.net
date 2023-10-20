using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.Net_PracticeProblem
{
    internal class Get_Customers
    {
       public static void GetCustomers(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM Customer", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string customerName = reader["CustomerName"].ToString();
                            string phone = reader["Phone"].ToString();
                            string address = reader["Address"].ToString();


                            Console.WriteLine($"Name: {customerName}, Phone: {phone}, Address: {address}");
                        }
                    }
                }
            }
        }
    }
}
