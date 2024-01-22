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
            Point point2 = new Point(2.1,5.3);
            point2.Print();
            Console.WriteLine($"count = {Point.count}");
            Point.LengthPoints(point1, point2);
            Console.Read();
        }
    }
}
