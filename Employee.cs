using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleIbmProject
{
    internal class Employee : Person
    {
        public int EmployeeId { get; set; }
        public string? Role { get; set; } //nullable cos of ?
        public string? Email { get; set; }
        public double Salary { get; set; }

        public Employee () { }
        
        public Employee (string ID, string name, string city, int age, int employeeID, string role, string email, double salary)
            : base(ID, name, city, age)
        {
            EmployeeId = employeeID;
            Role = role;
            Email = email;
            Salary = salary;    
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}, Role: {Role}, Email: {Email}, Salary: {Salary:C}");
        }

    }
}
