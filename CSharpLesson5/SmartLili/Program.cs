using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLili
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWash = double.Parse(Console.ReadLine());
            double priceToy = double.Parse(Console.ReadLine());

            int toysCount = 0;
            int money = 0;
            double savedMoney = 0;
            int brotherMoney = 0;

            for(int i=1; i<=age; i++)
            {
                if (i % 2 == 1)
                    toysCount++;

                else
                {
                    money += 10;
                    savedMoney += money;
                    brotherMoney++;
                }
            }

            double totalMoney = (savedMoney - brotherMoney) + (toysCount * priceToy);
            double diff = Math.Abs(totalMoney - priceWash);

            if (totalMoney >= priceWash)
            {
                Console.WriteLine("Yes! {0:f2}", diff);
            }

            else
            {
                Console.WriteLine("No! {0:f2}", diff);
            }
        }
    }
}
