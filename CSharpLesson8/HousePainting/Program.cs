using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double door = 1.2 * 2;
            double window = 1.5 * 1.5;
            double frontBack = (2 * x * x) - door;
            double sideWalls = (2*x * y) - 2 * window;
            double green = (frontBack + sideWalls) / 3.4;

            double roof = (2*x*y) + (x*h);
            double red = roof / 4.3;

            Console.WriteLine($"{green:F2}");
            Console.WriteLine($"{red:F2}");
        }
    }
}
