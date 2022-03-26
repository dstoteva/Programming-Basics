using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            for (int i = 2; i <= a; i++)
            {
                for (int j = 2; j <= b; j++)
                {
                    for (int k = 2; k <= c; k++)
                    {
                        bool iIsPrime = i % 2 == 0;
                        bool kIsPrime = k % 2 == 0;
                        bool jIsPrime = true;

                        for (int l = 2; l <= Math.Sqrt(j); l++)
                        {
                            if (j%l == 0)
                            {
                                jIsPrime = false;
                                break;
                            }
                        }
                        if (iIsPrime && kIsPrime && jIsPrime)
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                }
            }
        }
    }
}
