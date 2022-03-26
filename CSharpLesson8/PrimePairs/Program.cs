using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimePairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int beginFirst = int.Parse(Console.ReadLine());
            int beginSecond = int.Parse(Console.ReadLine());
            int firstDiff = int.Parse(Console.ReadLine());
            int secondDiff = int.Parse(Console.ReadLine());

            int endFirst = beginFirst + firstDiff;
            int endSecond = beginSecond + secondDiff;

            for (int i = beginFirst; i <= endFirst; i++)
            {
                for (int j = beginSecond; j <= endSecond; j++)
                {

                    bool isIPrime = true;
                    bool isJPrime = true;

                    for (int k = 2; k <= Math.Sqrt(i); k++)
                    {
                        if (i%k == 0)
                        {
                            isIPrime = false;
                            break;
                        }
                    }

                    for (int l = 2; l <= Math.Sqrt(j); l++)
                    {
                        if (j%l == 0)
                        {
                            isJPrime = false;
                            break;
                        }
                    }

                    if (isIPrime && isJPrime)
                    {
                        Console.WriteLine($"{i}{j}");
                    }
                }
            }
        }
    }
}
