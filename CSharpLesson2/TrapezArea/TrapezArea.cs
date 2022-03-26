using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrapezArea
{
    class TrapezArea
    {
        static void Main(string[] args)
        {
            //(b1 + b2) * h / 2
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double area = (b1 + b2) * h / 2;

            Console.WriteLine(area);
        }
    }
}
