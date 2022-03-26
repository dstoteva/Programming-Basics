﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsWithNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            double result = 0;

            switch (symbol)
            {
                case '+':
                    result = N1 + N2;

                    if (result % 2 == 0)
                        Console.WriteLine($"{N1} {symbol} {N2} = {result} - even");
                    else if(result % 2 != 0)
                        Console.WriteLine($"{N1} {symbol} {N2} = {result} - odd");
                    break;

                case '-':
                    result = N1 - N2;

                    if (result % 2 == 0)
                        Console.WriteLine($"{N1} {symbol} {N2} = {result} - even");
                    else if (result % 2 != 0)
                        Console.WriteLine($"{N1} {symbol} {N2} = {result} - odd");
                    break;

                case '*':
                    result = N1 * N2;

                    if (result % 2 == 0)
                        Console.WriteLine($"{N1} {symbol} {N2} = {result} - even");
                    else if (result % 2 != 0)
                        Console.WriteLine($"{N1} {symbol} {N2} = {result} - odd");
                    break;

                case '/':
                    if (N2 == 0)
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    else
                    {
                        result = (double)N1 / N2;
                        Console.WriteLine($"{N1} / {N2} = {result:f2}");
                    }
                    break;

                case '%':
                    if (N2 == 0)
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    else
                    {
                        result = N1 % N2;
                        Console.WriteLine($"{N1} % {N2} = {result}");
                    }
                    break;

            }


        }
    }
}
