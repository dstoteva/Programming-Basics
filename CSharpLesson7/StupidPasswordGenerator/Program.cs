﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j= 1; j <=n ; j ++)
                {
                    for (char k = 'a'; k <'a' + l; k++ )
                    {
                        for (char m = 'a'; m < 'a' + l; m++)
                        {
                            int maxNumber = Math.Max(i, j) +1;

                            for (int o = maxNumber; o <= n; o++)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ", i, j, k, m, o);
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
