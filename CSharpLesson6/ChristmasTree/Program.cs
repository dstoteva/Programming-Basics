using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftEmpty = n;
            int stars = 0;

            for (int j = 0; j <= n; j++)
            {
                string emptySpaces = new string(' ', leftEmpty);
                string allStars = new string('*', stars);
                Console.WriteLine(emptySpaces + allStars + " | " + allStars);
                leftEmpty--;
                stars++;
            }
        }
    }
}
