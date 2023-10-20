using System;
using System.Data;
using System.Data.SqlClient;
namespace ADO.Net_PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLOCALDB;Initial Catalog=AdoDotNet;Integrated Security=True";

            // 1. Add Customer Details
            Customer_Details.AddCustomer(connectionString);

            // 2. Get All Customers Details
            Get_Customers.GetCustomers(connectionString);

            // 3. Delete a Customer
            Delete_a_Customer.DeleteCustomer(connectionString);

            // 4. Update Customer Salary
            Update_Customer_Salary.UpdateCustomerSalary(connectionString);
        }
    }
}
    