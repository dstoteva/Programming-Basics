﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
                int n = int.Parse(Console.ReadLine());

                Console.Write("+");
                for (int i = 0; i < n - 2; i++)
                {
                    Console.Write(" -");

                }
                Console.WriteLine(" +");


                for (int j = 0; j < n - 2; j++)
                {
                    Console.Write("|");

                    for (int k = 0; k < n - 2; k++)
                    {
                        Console.Write(" -");
                    }
                    Console.WriteLine(" |");
                }

                Console.Write("+");
                for (int i = 0; i < n - 2; i++)
                {
                    Console.Write(" -");

                }
                Console.WriteLine(" +");
            
            
        }
    }
}
