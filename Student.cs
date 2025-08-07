using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleIbmProject
{
    internal class Student
    {
        public String studentName;
        int totalMarks = 0;
        int averageMarks = 0;
        string [] subjects = ["Math", "Science", "English", "History", "Geography"];
        
        public Student() {
            Console.Write("Enter student name: ");
            studentName = Console.ReadLine();

            Console.WriteLine("Enter student marks for the following subjects:");
            foreach (string subject in subjects){ 
                Console.Write($"{subject}: ");
                totalMarks +=  Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
        }
        public void CalculateAverage()
        {
            averageMarks = totalMarks / subjects.Length;
        }
        public void PrintTotalMarks()
        {
            Console.WriteLine($"The total marks of the {studentName} is: {totalMarks}");
        }

        public void PrintAverageMarks()
        {
            Console.WriteLine($"The average marks of the {studentName} is: {averageMarks}");
        }


    }
}
