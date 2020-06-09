using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Ring
{
    public class Round
    {
        public int X { get; }
        public int Y { get; }
        public int Radius { get; }

        public Round(int x, int y, int radius)
        {
            X = x;
            Y = y;
            if (radius < 1)
                throw new ArgumentException("Радиус отрицателен!");
            Radius = radius;
        }

        public double Length => 2 * Math.PI * Radius;

        public double Square => Math.PI * Radius * Radius;

        public override string ToString()
        {
            return "Координаты центра кргуа: (" + X + ", " + Y + "); радиус: " +
                   Radius + "; длина: " + Length + " площадь: " + Square;
        }
    }
}
