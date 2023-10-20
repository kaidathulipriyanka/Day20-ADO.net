using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.Net_PracticeProblem
{
    internal class Update_Customer_Salary
    {
       public static void UpdateCustomerSalary(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UPDATE Customer SET Salary = @Salary WHERE CustomerName = @CustomerName", connection))
                {
                    command.Parameters.AddWithValue("@Salary", 60000.00);
                    command.Parameters.AddWithValue("@CustomerName", "Battu Santhosh");
                    //command.ExecuteNonQuery();
                }
            }
        }
    }
}