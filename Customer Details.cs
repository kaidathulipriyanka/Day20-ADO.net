using System;
using System.Data;
using System.Data.SqlClient;

namespace ADO.Net_PracticeProblem
{
    public class Customer_Details
    {
      public static void AddCustomer(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO Customer (CustomerName, Phone, Address) VALUES (@CustomerName, @Phone, @Address)", connection))
                {
                    command.Parameters.AddWithValue("@CustomerName", "Priyanka");
                    command.Parameters.AddWithValue("@Phone", "8179664964");
                    command.Parameters.AddWithValue("@Address", "19-376 STV nagar");

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
