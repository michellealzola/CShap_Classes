using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagement
{
    internal class Vehicle
    {
        public string Make {  get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        public Vehicle (string Make, string Model)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = 0;
            this.Mileage = 0;
        }

        public Vehicle(string Make, string Model, int Year, int Mileage)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Mileage = Mileage;
        }

        public string DisplayInfo()
        {
            return $"Make: {Make}\nModel: {Model}\nYear: {Year}\nMileage: {Mileage}";
            
        }
    }
}
