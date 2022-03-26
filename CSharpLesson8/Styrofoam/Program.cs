using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Styrofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double area = double.Parse(Console.ReadLine());
            int windows = int.Parse(Console.ReadLine());
            double styroInAPack = double.Parse(Console.ReadLine());
            double styroPrice = double.Parse(Console.ReadLine());

            double houseArea = area - ((double)windows * 2.4);
            double totalArea = houseArea * 1.10;
            double packetsNeeded = Math.Ceiling(totalArea / styroInAPack);
            double price = packetsNeeded * styroPrice;

            double diff = Math.Abs(budget - price);

            if (budget<price)
            {
                Console.WriteLine($"Need more: {diff:F2}");
            }
            else
            {
                Console.WriteLine($"Spent: {price:F2}");
                Console.WriteLine($"Left: {diff:F2}");
            }
        }
    }
}
