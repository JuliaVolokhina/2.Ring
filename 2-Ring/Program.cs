using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Ring
{
    class Program
    {
        static void Main(string[] args)
        {
            var ring = FileReader.ReadFromFile();
            new FileReader(ring).SaveToFile();
        }
    }
}
