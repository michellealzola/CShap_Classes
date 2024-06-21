using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleAreaCalculation
{
    internal class Rectangle
    {
        public double Length {  get; set; }
        public double Breadth { get; set; }

        public Rectangle(double side)
        {
            Length = side;
            Breadth = side;
        }

        public Rectangle(double length, double side)
        {
            Length = length; 
            Breadth = side;
        }

        public double CalculateArea()
        {
            return Length * Breadth;
        }
    }
}
