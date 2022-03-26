using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cup
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dots = n;
            int hashtags = n * 3;
            int allSymbols = n * 5;
            

            for (int i = 1; i <= n/2; i++)
            {
                Console.Write(new string ('.', dots));
                Console.Write(new string('#', hashtags));
                Console.WriteLine(new string('.', dots));
                dots++;
                hashtags -= 2;
            }

            for (int i = 0; i < (n/2) +1; i++)
            {
                int middleDots = allSymbols - (2 * dots + 2);
                Console.Write(new string('.', dots));
                Console.Write('#');
                Console.Write(new string('.', middleDots));
                Console.Write('#');
                Console.WriteLine(new string('.', dots));
                middleDots -= 2;
                dots++;
            }
            dots--;
            Console.Write(new string('.', dots));
            Console.Write(new string('#', n));
            Console.WriteLine(new string('.', dots));

            hashtags = n + 4;
            dots = n * 2 - 2;

            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new string('.', dots));
                Console.Write(new string('#', hashtags));
                Console.WriteLine(new string('.', dots));
            }
            dots = (allSymbols - 10) / 2;

            Console.Write(new string('.', dots));
            Console.Write("D^A^N^C^E^");
            Console.WriteLine(new string('.', dots));

            dots = n * 2 - 2;
            for (int i = 0; i < (n/2) +1; i++)
            {
                Console.Write(new string('.', dots));
                Console.Write(new string('#', hashtags));
                Console.WriteLine(new string('.', dots));
            }
        }
    }
}
