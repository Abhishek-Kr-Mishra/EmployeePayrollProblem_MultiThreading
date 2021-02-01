using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollSystem_MultiThreading
{
    public class EmployeePayrollOperations
    {
        public List<EmployeeDetails> employeePayrollDetails = new List<EmployeeDetails>();
        public void AddEmployeeToPayroll(List<EmployeeDetails> employeePayrollDataList)
        {
            employeePayrollDataList.ForEach(employeeData =>
            {
                Console.WriteLine("Employee being Added: " + employeeData.EmpName);
                this.AddEmployeePayroll(employeeData);
                Console.WriteLine("Employee Added " + employeeData.EmpName);
            });
            Console.WriteLine(employeePayrollDataList.ToString());
        }
        public void AddEmployeePayroll(EmployeeDetails emp)
        {
            employeePayrollDetails.Add(emp);
        }

        public void AddEmployeeToPayrollToThread(List<EmployeeDetails> employePayrollDataDetails)
        {
            employePayrollDataDetails.ForEach(employeeData =>
            {
                Task thread = new Task(() =>
                {
                    Console.WriteLine("Employee being Added: " + employeeData.EmpName);
                    this.AddEmployeePayroll(employeeData);
                    Console.WriteLine("Employee Added " + employeeData.EmpName);
                });
                thread.Start();
            });
            Console.WriteLine(employePayrollDataDetails.ToString());
        }
        public int EmployeeCount()
        {
            return this.employeePayrollDetails.Count;
        }
    }
}
