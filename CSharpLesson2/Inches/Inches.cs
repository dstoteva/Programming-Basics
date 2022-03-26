using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inches
{
    class Inches
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());

            //2.54

            double centimeters = inches*2.54;

            Console.WriteLine(centimeters);
        }
    }
}
