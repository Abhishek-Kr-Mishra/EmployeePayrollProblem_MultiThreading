using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace EmployeePayrollSystem_MultiThreading
{
    class EmployeePaurollDatabaseOperations
    {
        public static string connectionString = "Server=(Localdb)\\MSSQLLocalDB;database=Payroll_Service;Trusted_Connection=true";
        SqlConnection connection = new SqlConnection(connectionString);
        public bool AddEmployeeWithThread(EmployeeDetails employeeDetails)
        {
            try
            {
                SqlCommand command = new SqlCommand("sp_AddEmployee", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EmpName", employeeDetails.EmpName);
                command.Parameters.AddWithValue("@StartDate", employeeDetails.StartDate);
                command.Parameters.AddWithValue("@Gender", employeeDetails.Gender);
                command.Parameters.AddWithValue("@PhoneNumber", employeeDetails.PhoneNumber);
                command.Parameters.AddWithValue("@Address", employeeDetails.Address);
                command.Parameters.AddWithValue("@DeptID", employeeDetails.DeptID);
                this.connection.Open();
                var result = command.ExecuteNonQuery();
                if (result != 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }
    }
}
