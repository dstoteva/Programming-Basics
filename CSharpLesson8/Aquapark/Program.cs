using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquapark
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int hours = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();

            month = month.ToLower();
            dayOrNight = dayOrNight.ToLower();

            double pricePerHour = 0;

            if (month=="march"||month=="april"||month=="may")
            {
                if (dayOrNight == "day")
                {
                    pricePerHour = 10.5;
                }
                else if(dayOrNight == "night")
                {
                    pricePerHour = 8.4;
                }
            }
            else if(month == "june" || month == "july" || month == "august")
            {
                if (dayOrNight == "day")
                {
                    pricePerHour = 12.6;
                }
                else if (dayOrNight == "night")
                {
                    pricePerHour = 10.2;
                }
            }

            if (people>=4)
            {
                pricePerHour *= 0.9;
            }
            if (hours>=5)
            {
                pricePerHour *= 0.5;
            }

            double totalPrice = people * pricePerHour*hours;

            Console.WriteLine($"Price per person for one hour: {pricePerHour:F2}");
            Console.WriteLine($"Total cost of the visit: {totalPrice:F2}");
        }
    }
}
