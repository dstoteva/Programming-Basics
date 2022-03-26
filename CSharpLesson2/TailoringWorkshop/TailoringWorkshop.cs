using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailoringWorkshop
{
    class TailoringWorkshop
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double pokrivkaPriceInDollars = ((length + 0.6) * (width+0.6))*7;
            double karePriceInDollars = ((length * length) / 4) * 9;

            double price = n*(pokrivkaPriceInDollars + karePriceInDollars);

            Console.WriteLine("{0:f2} USD", price);
            Console.WriteLine("{0:f2} BGN", price * 1.85);
        }
    }
}
