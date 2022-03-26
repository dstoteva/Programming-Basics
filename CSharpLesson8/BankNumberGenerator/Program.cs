using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            char d = char.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            int count = 0;

            

            for (int i = a; i <= 99; i++)
            {
                for (char j = b; j <= 'Z'; j++)
                {
                    for (char k = c; k <= 'z'; k++)
                    {
                        for (char l = d; l <= 'Z'; l++)
                        {
                            for (int m = e; m >= 10; m--)
                            {
                                int aSecondNum = i % 10;
                                int eSecondNum = m % 10;

                                if (aSecondNum == 2 && eSecondNum== 5)
                                {
                                    count++;

                                    if (count == N)
                                    {
                                        Console.WriteLine($"{i}{j}{k}{l}{m}");
                                    }
                                }   
                            }
                        }
                    }
                }
            }
        }
    }
}
