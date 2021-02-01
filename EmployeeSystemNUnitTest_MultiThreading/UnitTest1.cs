using EmployeePayrollSystem_MultiThreading;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace EmployeeSystemNUnitTest_MultiThreading
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Given10Employee_WhenAddesTDList_ShouldMatchEmployeeEntities()
        {
            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();
            employeeDetails.Add(new EmployeeDetails(EmpID: 1, EmpName: "Bruce", StartDate: DateTime.Now, Gender: "Male", PhoneNumber: 7559171697, Address: "Mumbai", DeptID: 1, PayrollId: 1, BasicPay: 300000, Deduction: 24000, IncomeTax: 18000, NetPay: 26500));
            employeeDetails.Add(new EmployeeDetails(EmpID: 2, EmpName: "Wayne", StartDate: DateTime.Now, Gender: "Male", PhoneNumber: 7894563321, Address: "Delhi", DeptID: 2, PayrollId: 2, BasicPay: 300000, Deduction: 24000, IncomeTax: 18000, NetPay: 26500));
            employeeDetails.Add(new EmployeeDetails(EmpID: 3, EmpName: "Peter", StartDate: DateTime.Now, Gender: "Male", PhoneNumber: 1236547890, Address: "Delhi", DeptID: 1, PayrollId: 3, BasicPay: 250000, Deduction: 18000, IncomeTax: 12000, NetPay: 18000));
            employeeDetails.Add(new EmployeeDetails(EmpID: 4, EmpName: "Parker", StartDate: DateTime.Now, Gender: "Male", PhoneNumber: 2145698730, Address: "Delhi", DeptID: 2, PayrollId: 4, BasicPay: 300000, Deduction: 24000, IncomeTax: 18000, NetPay: 26500));
            employeeDetails.Add(new EmployeeDetails(EmpID: 5, EmpName: "Abhishek", StartDate: DateTime.Now, Gender: "Male", PhoneNumber: 7559171697, Address: "Delhi", DeptID: 1, PayrollId: 5, BasicPay: 300000, Deduction: 24000, IncomeTax: 18000, NetPay: 26500));
            employeeDetails.Add(new EmployeeDetails(EmpID: 6, EmpName: "Wonder Woman", StartDate: DateTime.Now, Gender: "Female", PhoneNumber: 7559171697, Address: "Bengaluru", DeptID: 2, PayrollId: 6, BasicPay: 300000, Deduction: 24000, IncomeTax: 18000, NetPay: 26500));
            employeeDetails.Add(new EmployeeDetails(EmpID: 7, EmpName: "Iron Man", StartDate: DateTime.Now, Gender: "Male", PhoneNumber: 7559171697, Address: "Delhi", DeptID: 2, PayrollId: 7, BasicPay: 300000, Deduction: 24000, IncomeTax: 18000, NetPay: 26500));
            employeeDetails.Add(new EmployeeDetails(EmpID: 8, EmpName: "Wayne", StartDate: DateTime.Now, Gender: "Male", PhoneNumber: 7559171697, Address: "Delhi", DeptID: 2, PayrollId: 8, BasicPay: 300000, Deduction: 24000, IncomeTax: 18000, NetPay: 26500));
            employeeDetails.Add(new EmployeeDetails(EmpID: 9, EmpName: "Wayne", StartDate: DateTime.Now, Gender: "Male", PhoneNumber: 7559171697, Address: "Delhi", DeptID: 2, PayrollId: 9, BasicPay: 300000, Deduction: 24000, IncomeTax: 18000, NetPay: 26500));
            employeeDetails.Add(new EmployeeDetails(EmpID: 10, EmpName: "Wayne", StartDate: DateTime.Now, Gender: "Male", PhoneNumber: 7559171697, Address: "Delhi", DeptID: 2, PayrollId: 10, BasicPay: 300000, Deduction: 24000, IncomeTax: 18000, NetPay: 26500));

            EmployeePayrollOperations employeePayrollOperations = new EmployeePayrollOperations();
            DateTime startDateTime = DateTime.Now;
            employeePayrollOperations.AddEmployeeToPayroll(employeeDetails);
            DateTime stopDateTime = DateTime.Now;
            Console.WriteLine("Duration without thread :" + (stopDateTime - startDateTime));

            DateTime startDateTimeWithThread = DateTime.Now;
            employeePayrollOperations.AddEmployeeToPayrollToThread(employeeDetails);
            DateTime stopDateTimeWithThread = DateTime.Now;
            Console.WriteLine("Duration with thread :" + (stopDateTime - startDateTime));
        }
    }
}