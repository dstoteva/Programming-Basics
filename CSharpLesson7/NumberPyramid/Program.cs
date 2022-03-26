using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(number + " ");
                    number++;

                    if (number>n)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                if (number > n)
                {
                    break;
                }
                
            }
        }
    }
}
