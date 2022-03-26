using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxNumber = int.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());

                if (inputNumber < maxNumber)
                {
                    maxNumber = inputNumber;
                }
            }

            Console.WriteLine(maxNumber);
        }
    }
}
