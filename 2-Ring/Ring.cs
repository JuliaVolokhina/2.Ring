using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Ring
{
    public class Ring : Round
    {
        public int RadiusOut { get; }

        public Ring(int x, int y, int radius, int radiusout) : base(x, y, radius)
        {
            if (radiusout < 1)
                Console.WriteLine("Отрицательный радиус!");

            else if (radiusout < radius)
                Console.WriteLine("Внутренний радиус не может быть больше внешнего радиуса!");

            RadiusOut = radiusout;
        }

        public double Lengthring()
        {
            double lr = 2 * Math.PI * RadiusOut;
            return lr;
        }

        public double FullLength()
        {
            double fl = Lengthring() * 2;
            return fl;
        }

        public double Square()
        {
            double s = Math.PI * (RadiusOut * RadiusOut - Radius * Radius);
            return s;
        }

        public override string ToString()
        {
            return "Центр кольца: (" + X + ", " + Y + "); внутренний радиус: " +
                   Radius + "; внешний радиус: " + RadiusOut + "; длина: " + FullLength() + " площадь: " + Square();
        }
    }
}
