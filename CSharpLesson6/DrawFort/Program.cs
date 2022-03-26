using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int roofParts = n / 2;
            int roofDashes = 2*n - 4 - 2*roofParts;

            Console.Write('/');
            Console.Write(new string ('^', roofParts));
            Console.Write('\\');
            
            Console.Write(new string ('_', roofDashes));
            
            Console.Write('/');
            Console.Write(new string('^', roofParts));
            Console.WriteLine('\\');

            for (int i = 0; i < n-2; i++)
            {
                int emptySpaces = (n * 2) - 2;
                Console.Write('|');
                if (i == n - 3)
                {
                    emptySpaces = (n - 1 - roofDashes/2);
                    Console.Write(new string(' ', emptySpaces));
                    Console.Write(new string ('_', roofDashes));
                    Console.Write(new string(' ', emptySpaces));
                }
                else
                    Console.Write(new string(' ', emptySpaces));

                Console.WriteLine('|');
                
            }

            int bottomDashes = n / 2;
            Console.Write('\\');
            Console.Write(new string('_', bottomDashes));
            Console.Write('/');
            Console.Write(new string(' ', roofDashes));
            Console.Write('\\');
            Console.Write(new string('_', bottomDashes));
            Console.Write('/');
        }
    }
}
