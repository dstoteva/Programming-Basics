using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int dots = ((n * 3) - 2)/2;
            int emptySpaces = 0;
            int stars = n * 2;
            int middleDashes = (n * 2) - 2;

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string ('.', dots));
                Console.Write('/');
                Console.Write(new string(' ', emptySpaces));
                Console.Write('\\');
                Console.WriteLine(new string('.', dots));

                dots--;
                emptySpaces += 2;
            }
            dots++;

            Console.Write(new string('.', dots));
            Console.Write(new string('*', stars));
            Console.WriteLine(new string('.', dots));

            for (int i = 0; i < n*2; i++)
            {
                Console.Write(new string('.', dots));
                Console.Write('|');
                Console.Write(new string ('\\', middleDashes));
                Console.Write('|');
                Console.WriteLine(new string('.', dots));
            }

            stars -= 2;
            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new string('.', dots));
                Console.Write('/');
                Console.Write(new string('*', stars));
                Console.Write('\\');
                Console.WriteLine(new string('.', dots));

                dots--;
                stars += 2;
            }
        }
    }
}
