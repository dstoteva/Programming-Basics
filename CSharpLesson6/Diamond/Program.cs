using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftRight = (n - 1) / 2;
            int mid = n - 2 - 2 * leftRight;

            for (int i = 0; i < (n + 1) / 2; i++)
            {
                Console.Write(new string('-', leftRight));
                Console.Write('*');

                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write('*');
                }

                Console.WriteLine(new string('-', leftRight));
                mid += 2;
                leftRight--;
            }

            leftRight = 1;
            mid = n - 2 - 2 * leftRight;
            for (int i = 0; i < (n - 1) / 2; i++)
            {
                Console.Write(new string('-', leftRight));
                Console.Write('*');

                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write('*');
                }

                Console.WriteLine(new string('-', leftRight));
                leftRight++;
                mid -= 2;
            }
        }
    }
}
