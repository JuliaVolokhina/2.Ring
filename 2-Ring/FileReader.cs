using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Ring
{
    public class FileReader
    {
        private Ring ringR;

        public FileReader(Ring ring)
        {
            ringR = ring;
        }

        public static Ring ReadFromFile()
        {
            StreamReader sr = new StreamReader("input.txt");
            char[] charSeparators = new char[] { ' ', '\n' };
            string[] mas = sr.ReadToEnd().Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
            if (mas != null && mas.Length == 4)
            {
                if (!int.TryParse(mas[0], out var x))
                {
                    Console.WriteLine("Неккоректная кордината x");
                }

                if (!int.TryParse(mas[1], out var y))
                {
                    Console.WriteLine("Неккоректная кордината y");
                }

                if (!int.TryParse(mas[2], out var r))
                {
                    Console.WriteLine("Неккоректный радиус");
                }

                if (!int.TryParse(mas[3], out var r2))
                {
                    Console.WriteLine("Неккоректный внешний радиус");
                }

                Ring ring = new Ring(x, y, r, r2);
                return ring;
            }

            return null;
        }

        public void SaveToFile()
        {
            StreamWriter sw = new StreamWriter("output.txt");
            sw.WriteLine(ringR.ToString());
        }
    }
}
