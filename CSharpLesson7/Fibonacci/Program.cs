using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int fibonacci1 = 1;
            int fibonacci2 = 1;

            for (int i = 0; i < n-1; i++)
            {
                int fibonacciNext = fibonacci1 + fibonacci2;
                fibonacci1 = fibonacci2;
                fibonacci2 = fibonacciNext;
            }
            Console.WriteLine(fibonacci2);
        }
    }
}
