using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            bool IsWeekday = day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday";
            bool IsWeekend = day == "Saturday" || day == "Sunday";

            double price = -1;

            if (IsWeekday)
            {
                switch(fruit)
                {
                    case "banana":
                        price = quantity * 2.50;
                        break;
                    case "apple":
                        price = quantity * 1.2;
                        break;
                    case "orange":
                        price = quantity * 0.85;
                        break;
                    case "grapefruit":
                        price = quantity * 1.45;
                        break;
                    case "kiwi":
                        price = quantity * 2.70;
                        break;
                    case "pineapple":
                        price = quantity * 5.50;
                        break;
                    case "grapes":
                        price = quantity * 3.85;
                        break;
                }
            }
            else if(IsWeekend)
            {
                switch (fruit)
                {
                    case "banana":
                        price = quantity * 2.70;
                        break;
                    case "apple":
                        price = quantity * 1.25;
                        break;
                    case "orange":
                        price = quantity * 0.9;
                        break;
                    case "grapefruit":
                        price = quantity * 1.6;
                        break;
                    case "kiwi":
                        price = quantity * 3;
                        break;
                    case "pineapple":
                        price = quantity * 5.60;
                        break;
                    case "grapes":
                        price = quantity * 4.20;
                        break;
                }
            }
            else
                Console.WriteLine("error");
            if(price == -1)
                Console.WriteLine("error");
            else
                Console.WriteLine("{0:f2}", price);
        }

    }
}
