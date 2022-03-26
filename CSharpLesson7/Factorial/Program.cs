using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 1;

            do
            {
                number = number * n;
                n--;
            } while (n>0);
            Console.WriteLine(number);
        }
    }
}
