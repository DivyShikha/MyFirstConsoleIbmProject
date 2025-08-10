using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleIbmProject
{
    internal class ElectricCar(int battery, int range, int doors, string company, string type, string make, string model, int year) 
        : Car( doors,  company,  type,  make,  model,  year)
    {
        public int BatteryKWh { get; } = battery;
        public int RangeKm { get; } = range;

        public string Msg { get; set; } = "Hii, I am Vehicle class";


        public override string ToString()
        {
            return $"Make: {make}, Model: {model}, Year: {year}, Doors: {doors}, company: {company}, Type: {type}, Battery: {BatteryKWh}, Range: {RangeKm} ";
        }
    }
}
