using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme14Pr1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point();
            point1.Print();
            Console.WriteLine($"count = {Point.count}");
            Console.Read();
        }
    }
}
