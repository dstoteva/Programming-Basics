using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAndProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int a = 1;
            int b = 9;
            int c = 0;
            int d = 9;

            int nthirdNum = n % 10;
            bool isTrue = true;

            for (int i = a; i <= 9; i++)
            {
                for (int j = b; j >= a; j--)
                {
                    for (int k = c; k <= 9; k++)
                    {
                        for (int l = d; l >= c; l--)
                        {

                            int sum = i + j + k + l;
                            int product = i * j * k * l;

                            if (isTrue == false)
                            {
                                break;
                            }

                            if (sum == product && nthirdNum == 5)
                            {

                                Console.WriteLine($"{i}{j}{k}{l}");
                                isTrue = false;
                            }
                            else if (product / sum == 3 && n % 3 == 0)
                            {

                                Console.WriteLine($"{l}{k}{j}{i}");
                                isTrue = false;
                            }

                            

                        }
                    }
                }
            }
            if (isTrue == true)
            {
                Console.WriteLine("Nothing found");
            }
        }
    }
}
