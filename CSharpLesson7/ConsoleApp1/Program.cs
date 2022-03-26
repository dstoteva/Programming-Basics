using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 1;

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(number);
                number *= 2;
            }
        }
    }
}
