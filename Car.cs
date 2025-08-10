using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleIbmProject
{
    internal  class Car(int doors, string company, string type, string make, string model, int year) : Vehicle (make, model, year)
    {
        public Car() : this (0,"","","","", 0)
         { }
        
        public int doors { get; } = doors;
        public string company { get; } = company;
        public string type { get; } = type;

        public string  Msg { get; set; } = "Hii, I am Vehicle class";

        public override string DescribeVehicle()
        {
            return $"{doors}, {company}, {type}";
        }
        public override string ToString()
        {
            return $"It has {doors} doors, {type} type and belongs to {company}. The message is {Msg}";
        }
    }
}
