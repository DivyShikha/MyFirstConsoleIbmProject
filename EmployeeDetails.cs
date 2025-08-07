using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleIbmProject
{
    internal class EmployeeDetails
    {
        string employeeName;
        string employeeID;
        float employeeAnnualSalary;

        public EmployeeDetails() { }

        public EmployeeDetails(string name, string id, float salary)
        {
            employeeName = name;
            employeeID = id;
            employeeAnnualSalary = salary;
        }

        public void captureEmployeeDetails()
        {
            Console.Write("Enter employee name:");
            employeeName = Console.ReadLine();  
            Console.Write("Enter employee ID:");
            employeeID = Console.ReadLine();
            Console.Write("Enter employee salary:");
            employeeAnnualSalary = Convert.ToInt32(Console.ReadLine());
        }
        
        public string calculateAnnualSalary()
        {
            float hra = employeeAnnualSalary * 0.02f;
            float insurance = Math.Min(2000, employeeAnnualSalary * 0.05f);
            float basic = employeeAnnualSalary - (hra + insurance);
            float otherAllowances = employeeAnnualSalary - (hra + insurance + basic);

            string salarySlip = "----------------------------------\n";
            salarySlip +=       "                 SALARY SLIP      \n";
            salarySlip += "----------------------------------\n";
            salarySlip += $"Employee Name:        {employeeName}\n";
            salarySlip += $"Employee ID:          {employeeID}\n";
            salarySlip += "----------------------------------\n";
            salarySlip += $"Basic Salary:        {basic:F2}\n";
            salarySlip += $"HRA:                 {hra:F2}\n";
            salarySlip += $"Insurance:           {insurance:F2}\n";
            salarySlip += $"Other Allowances:    {otherAllowances:F2}\n";
            salarySlip += "----------------------------------\n";
            salarySlip += $"Gross Salary:    {employeeAnnualSalary:F2}\n";
            salarySlip += "----------------------------------\n";

            return salarySlip;

        }



    }
}
