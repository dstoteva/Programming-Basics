using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            double transportMoney = 0;

            if(count <=4)
            {
                transportMoney = budget * 75 / 100;
            }

            else if(count >=5 && count <=9)
            {
                transportMoney = budget * 60 / 100;
            }

            else if(count >= 10 && count <=24 )
            {
                transportMoney = budget * 50 / 100;
            }

            else if(count >= 25 && count <=49)
            {
                transportMoney = budget * 40 / 100;
            }

            else if(count >= 50)
            {
                transportMoney = budget * 25 / 100;
            }

            double moneyNeeded = 0;

            switch (category)
            {
                case "VIP":
                    moneyNeeded = count * 499.99 + transportMoney;

                    if(moneyNeeded<budget)
                        Console.WriteLine("Yes! You have {0:f2} leva left.", (budget - moneyNeeded));
                    else if(moneyNeeded>budget)
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(budget - moneyNeeded));
                    break;

                case "Normal":
                    moneyNeeded = count * 249.99 + transportMoney;

                    if (moneyNeeded < budget)
                        Console.WriteLine("Yes! You have {0:f2} leva left.", (budget - moneyNeeded));
                    else if (moneyNeeded > budget)
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(budget - moneyNeeded));
                    break;
            }
        }
    }
}
