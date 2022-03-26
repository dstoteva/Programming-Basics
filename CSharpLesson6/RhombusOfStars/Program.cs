using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftEmpty = n - 1;

            for (int i = 0; i < n; i++)
            {
                string whiteSpaces = new string(' ', leftEmpty);
                Console.Write(whiteSpaces);

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                leftEmpty--;
            }

            leftEmpty = 1;
            int stars = n - 1;

            for (int i = 0; i < n-1; i++)
            {
                string whiteSpaces = new string(' ', leftEmpty);
                Console.Write(whiteSpaces);

                for (int j = 0; j < stars; j++)
                {
                    Console.Write("* ");
                }

                leftEmpty++;
                stars--;

                Console.WriteLine();
            }
        }
    }
}
