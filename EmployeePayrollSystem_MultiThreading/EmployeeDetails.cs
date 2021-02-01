using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayrollSystem_MultiThreading
{
    public class EmployeeDetails
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public DateTime StartDate { get; set; }
        public string Gender { get; set; }
        public long PhoneNumber { get; set; }
        public string Address { get; set; }
        public int DeptID { get; set; }
        public int PayrollID { get; set; }
        public double BasicPay { get; set; }
        public double Deduction { get; set; }
        public double IncomeTax { get; set; }
        public double NetPay { get; set; }

        public EmployeeDetails(int EmpID, string EmpName, DateTime StartDate, string Gender, long PhoneNumber, string Address, int DeptID,
                                  int PayrollId, double BasicPay, double Deduction, double IncomeTax, double NetPay)
        {
            this.EmpID = EmpID;
            this.EmpName = EmpName;
            this.StartDate = StartDate;
            this.Gender = Gender;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
            this.DeptID = DeptID;
            this.PayrollID = PayrollID;
            this.BasicPay = BasicPay;
            this.BasicPay = BasicPay;
            this.Deduction = Deduction;
            this.IncomeTax = IncomeTax;
            this.NetPay = NetPay;
        }

    }
}
