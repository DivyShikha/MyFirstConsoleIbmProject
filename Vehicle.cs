using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleIbmProject
{
    internal abstract class Vehicle(string make, string model, int year)
    {
        public Vehicle() : this("", "", 0) // calls the primary constructor with defaults
        {
        }
        public string Make { get; set; } = make;
        public string Model { get; set; } = model;
        public int Year { get; set; } = year;

        public string Msg1 { get; set; } = "Hii, I am the  Vehicle class";

        public abstract string DescribeVehicle();

        public override string ToString() => $"{Year} {Make} {Model}";

    }
}
