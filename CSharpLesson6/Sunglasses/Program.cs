using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int stars = 2*n;
            int emptySpaces = n;

            string allStars = new string('*', stars);
            string whiteSpaces = new string(' ', emptySpaces);

            Console.WriteLine(allStars + whiteSpaces + allStars);

            for (int i = 0; i < n-2; i++)
            {
                Console.Write('*');
                Console.Write(new string('/', 2*n-2));
                Console.Write('*');

                if(i == (n - 1) / 2 - 1)
                    Console.Write(new string('|', n));
                else
                    Console.Write(new string(' ', n));

                Console.Write('*');
                Console.Write(new string('/', 2*n - 2));
                Console.Write('*');
                Console.WriteLine();
            }

            Console.WriteLine(allStars + whiteSpaces + allStars);
        }
    }
}
