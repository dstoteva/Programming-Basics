using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int hrizantemi = int.Parse(Console.ReadLine());
            int rozi = int.Parse(Console.ReadLine());
            int laleta = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string day = Console.ReadLine();

            double hrizantemiPrice = 0;
            double roziPrice = 0;
            double laletaPrice = 0;

            if (season=="Spring"||season=="Summer")
            {
                hrizantemiPrice = 2*hrizantemi;
                roziPrice = 4.10*rozi;
                laletaPrice = 2.5*laleta;



            }
            else if (season=="Autumn"|| season=="Winter")
            {
                hrizantemiPrice = 3.75*hrizantemi;
                roziPrice = 4.5*rozi;
                laletaPrice = 4.15*laleta;
            }

            double price = hrizantemiPrice + roziPrice + laletaPrice;

            if (day == "Y")
            {
                price *= 1.15;
            }

            if (season == "Spring" && laleta > 7)
            {
                price *= 0.95;
            }
            else if (season == "Winter" && rozi>9)
            {
                price *= 0.9;
            }

            if (hrizantemi+rozi+laleta > 20)
            {
                price *= 0.8;
            }

            double totalPrice = price + 2;

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
