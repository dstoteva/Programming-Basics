using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dots = n + 1;
            int dashes = n * 2 + 1;

            Console.Write(new string ('.', dots));
            Console.Write(new string ('_', dashes));
            Console.WriteLine(new string('.', dots));

            dashes = n * 2 - 1;

            for (int i = 0; i < n; i++)
            {
                dots--;

                Console.Write(new string('.', dots));
                Console.Write("//");
                Console.Write(new string('_', dashes));
                Console.Write("\\");
                Console.Write("\\");
                Console.WriteLine(new string('.', dots));
                dashes += 2;
            }
            Console.Write("//");
            dashes = ((2 * (n + 1) + 2 * n + 1) - 4 - 5) / 2;
            Console.Write(new string('_', dashes));
            Console.Write("STOP!");
            Console.Write(new string('_', dashes));
            Console.Write("\\");
            Console.WriteLine("\\");

            dots = 0;
            dashes = n * 4 - 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', dots));
                Console.Write("\\");
                Console.Write("\\");
                Console.Write(new string('_', dashes));
                Console.Write("//");
                Console.WriteLine(new string('.', dots));

                dots++;
                dashes -= 2;

            }
        }
    }
}
