using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleIbmProject
{
    internal class ConsultingEmployee : Employee
    {
        public string? ConsultingFirm { get; set; } //nullable
        public int ConsultingDuration { get; set; }

        public ConsultingEmployee() { }
        public ConsultingEmployee(string id, string name, string city, int age, int empId, string role, string email, double salary, string consultingFirm, int consultingDuration)
            : base ( id,  name,  city,  age,  empId,  role,  email,  salary)
        {
            ConsultingFirm = consultingFirm;
            ConsultingDuration = consultingDuration;    
        }
        public string GetConsultingEmployeeDetails()
        {
            return $"{ID}, {name}, {city}, {age}, {EmployeeId}, {Role}, {Email}, {Salary}, {ConsultingFirm}, { ConsultingDuration}";
        }
        public void DisplayConsultingEmployeeDetails()
        {
            Console.WriteLine($"Consulting Firm is {ConsultingFirm}, Consulting Duration is {ConsultingDuration}");
        }

    }
}
