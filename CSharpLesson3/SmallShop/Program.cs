using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            

            //coffee	water	beer	sweets	peanuts

            if (town == "Sofia")
            {
                switch (product)
                {
                    case "coffee":
                        quantity = quantity * 0.5;
                        break;
                    case "water":
                        quantity = quantity * 0.8;
                        break;
                    case "beer":
                        quantity = quantity * 1.2;
                        break;
                    case "sweets":
                        quantity = quantity * 1.45;
                        break;
                    case "peanuts":
                        quantity = quantity * 1.6;
                        break;
                }

            }
            else if (town == "Plovdiv")
            {
                switch (product)
                {
                    case "coffee":
                        quantity = quantity * 0.4;
                        break;
                    case "water":
                        quantity = quantity * 0.7;
                        break;
                    case "beer":
                        quantity = quantity * 1.15;
                        break;
                    case "sweets":
                        quantity = quantity * 1.3;
                        break;
                    case "peanuts":
                        quantity = quantity * 1.5;
                        break;
                }
            }
            else if (town == "Varna")
            {
                switch (product)
                {
                    case "coffee":
                        quantity = quantity * 0.45;
                        break;
                    case "water":
                        quantity = quantity * 0.7;
                        break;
                    case "beer":
                        quantity = quantity * 1.1;
                        break;
                    case "sweets":
                        quantity = quantity * 1.35;
                        break;
                    case "peanuts":
                        quantity = quantity * 1.55;
                        break;
                }
            }
            Console.WriteLine(quantity);
        }
    }
}
