using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int lastNumber = n % 10;
            int secondNumber = (n / 10)%10;
            int firstNumber = (n / 100) % 10;

            for (int i = 0; i < firstNumber+secondNumber; i++)
            {
                for (int j = 0; j < firstNumber +lastNumber; j++)
                {
                    if (n%5 == 0)
                    {
                        n -= firstNumber;
                    }
                    else if (n%3==0)
                    {
                        n -= secondNumber;
                    }
                    else if (n%5!=0 && n%3!=0)
                    {
                        n += lastNumber;
                    }

                    Console.Write($"{n} ");
                }
                Console.WriteLine();
            }
        }
    }
}
