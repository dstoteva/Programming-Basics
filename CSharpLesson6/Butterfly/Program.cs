using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int starsAndDashes = n - 2;

            for (int i = 1; i <= n-2; i++)
            {
                if(i%2 == 1)
                {
                    Console.Write(new string ('*', starsAndDashes));
                    Console.Write("\\ /");
                    Console.WriteLine(new string ('*', starsAndDashes));
                }
                else
                {
                    Console.Write(new string('-', starsAndDashes));
                    Console.Write("\\ /");
                    Console.WriteLine(new string('-', starsAndDashes));
                }
                    
            }

            int emptySpaces = n - 1;
            Console.Write(new string(' ', emptySpaces));
            Console.WriteLine('@');

            for (int i = 1; i <= n-2; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write(new string('*', starsAndDashes));
                    Console.Write("/ \\");
                    Console.WriteLine(new string('*', starsAndDashes));
                }
                else
                {
                    Console.Write(new string('-', starsAndDashes));
                    Console.Write("/ \\");
                    Console.WriteLine(new string('-', starsAndDashes));
                }
            }
        }
    }
}
