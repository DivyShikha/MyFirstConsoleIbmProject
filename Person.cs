using System.Runtime.InteropServices;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleIbmProject
{
    internal class Person
    {
        public string ID { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public int age { get; set; } 

        public Person() { }

        public Person(string ID, string name, string city, int age)
        {
            this.ID = ID;
            this.name = name;
            this.city = city;
            this.age = age;
        }
        public void UpdatePersonInfo(string name, string city, int age)
        {
            this.name = name;
            this.city = city;
            this.age = age;
        }
        public void DisplayPersonInfo()
        {
            Console.WriteLine($"ID: {ID}, Name: {name}, City: {city}, Age: {age}"); 
        }
        public override string ToString()
        {
            return ($"Name: {name} \n ID: {ID} \n City: {city} \n Age: {age}");
        }



        
    }
}
