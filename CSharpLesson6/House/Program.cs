using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int dashes = (n - 1) / 2;
            int stars = 0;

            if (n % 2 == 0)
                stars = 2;
            else
                stars = 1;

            for (int i = 0; i < (n+1)/2; i++)
            {
                Console.Write(new string('-', dashes));

                Console.Write(new string('*', stars));
                stars += 2;

                Console.Write(new string('-', dashes));
                dashes--;

                Console.WriteLine();
            }

            stars = n - 2;
            for (int i = 0; i < n/2; i++)
            {
                Console.Write('|');
                Console.Write(new string('*', stars));
                Console.Write('|');
                Console.WriteLine();
            }
        }
    }
}
