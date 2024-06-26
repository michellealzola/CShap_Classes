﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceCalculation
{
    internal class Point
    {
        private int x;
        private int y;

        public Point(int x, int y)
        {
            this.x = x; this.y = y;
        }

        public int CalculateDistance()
        {
            return Math.Abs(x - y);
        }
    }
}
