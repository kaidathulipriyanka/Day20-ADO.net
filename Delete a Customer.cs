using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.Net_PracticeProblem
{
    internal class Delete_a_Customer
    {
       public static void DeleteCustomer(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("DELETE FROM Customer WHERE CustomerName = @CustomerName", connection))
                {
                    command.Parameters.AddWithValue("@CustomerName", "Priyanka");
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
