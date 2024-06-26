using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateImmutableClass
{
    internal class Car
    {
        public string Make {  get; init; }
        public string Model { get; init; }
        public int Year { get; init; }

        public string DisplayCar()
        {
            return $"Make: {Make} | Model: {Model} | Year: {Year}";
        }
    }
}
