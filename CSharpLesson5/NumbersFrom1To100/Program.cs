using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersFrom1To100
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int result = 0;

            for( int i=1; i<=a; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());

                result += inputNumber;
            }

            Console.WriteLine(result);
        }
    }
}
