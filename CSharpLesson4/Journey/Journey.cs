using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journey
{
    class Journey
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double price = 0;

            if (budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");

                switch (season)
                {
                    case "summer":
                        price = budget * 30 / 100;
                        Console.WriteLine("Camp - {0:f2}", price);
                        break;
                    case "winter":
                        price = budget * 70/ 100;
                        Console.WriteLine("Hotel - {0:f2}", price);
                        break;
                }
            }

            else if (budget > 100 && budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");

                switch (season)
                {
                    case "summer":
                        price = budget * 40 / 100;
                        Console.WriteLine("Camp - {0:f2}", price);
                        break;
                    case "winter":
                        price = budget * 80 / 100;
                        Console.WriteLine("Hotel - {0:f2}", price);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Somewhere in Europe");

                price = budget * 90 / 100;

                Console.WriteLine("Hotel - {0:f2}", price);
            }

        }
    }
}
