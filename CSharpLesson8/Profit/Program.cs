using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int five = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            int oneCount = 0;
            int twoCount = 0;
            int fiveCount = 0;


            for (int i = 0; i <= one; i++)
            {
                for (int j = 0; j <= two; j++)
                {
                    for (int k = 0; k <= five; k++)
                    {
                        int currentSum = k * 5 + j * 2 + i;

                        if (currentSum == sum)
                        {
                            oneCount = i;
                            twoCount = j;
                            fiveCount = k;

                            Console.WriteLine($"{oneCount} * 1 lv. + {twoCount} * 2 lv. + {fiveCount} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }
        }
    }
}
