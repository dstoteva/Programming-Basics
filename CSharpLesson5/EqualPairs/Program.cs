using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int diff = 0;
            int maxDiff = -1000000;

            for(int i = 1; i <= n; i++)
            {
                int inputNumber1 = int.Parse(Console.ReadLine());
                int inputNumber2 = int.Parse(Console.ReadLine());

                if (i > 1)
                    diff = Math.Abs(sum - (inputNumber1 + inputNumber2));
                sum = inputNumber1 + inputNumber2;

                if (diff > maxDiff)
                    maxDiff = diff;
            }
            if(diff == 0)
                Console.WriteLine($"Yes, value={sum}");
            else
                Console.WriteLine($"No, maxdiff={maxDiff}");
        }
    }
}
