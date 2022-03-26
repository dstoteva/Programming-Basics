using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            

            while (true)
            {
                Console.WriteLine("Enter even number:");

                int number = 0;

                bool isInteger = int.TryParse(Console.ReadLine(), out number);

                if (isInteger)
                {
                    if (number % 2 == 0)
                    {
                        Console.WriteLine("Even number entered: {0}", number);
                        break;
                    }
                    Console.WriteLine("The number is not even.");

                }
                else
                    Console.WriteLine("Invalid number!");


            }
        }
    }
}
