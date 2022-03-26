using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int minNumber = int.MaxValue;

            for(int i = 1; i<=n; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());

                if(inputNumber < minNumber)
                {
                    minNumber = inputNumber;
                }
            }

            Console.WriteLine(minNumber);

        }
    }
}
