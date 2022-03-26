using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinCodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            char M = '!';
            char N = ':';

            int count = 0;


            for (int k = 1; k <= a; k++)
            {
                for (int l = 1; l <= b; l++)
                {
                    if (count == max)
                    {
                        break;
                    }
                    else
                    {
                        count++;

                        if (M > 47)
                        {
                            M = '!';
                        }
                        if (N > 64)
                        {
                            N = ':';
                        }

                        Console.Write($"{M}{N}{k}{l}{N}{M}|");
                        M++;
                        N++;
                    }
                }
            }
        }
    }
}
