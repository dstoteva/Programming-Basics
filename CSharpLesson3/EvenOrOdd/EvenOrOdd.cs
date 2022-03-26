using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    class EvenOrOdd
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            num = num % 2;

            if (num == 0)
                Console.WriteLine("even");
            else if (num != 0) 
                Console.WriteLine("odd");
        }
    }
}
