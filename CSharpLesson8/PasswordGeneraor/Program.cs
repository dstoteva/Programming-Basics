using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGeneraor
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            b = char.ToUpper(b);
            c = char.ToLower(c);

            int count = 0;

            for (int i = 1; i <= a; i++)
            {
                for (char j = 'A'; j <= b; j++)
                {
                    for (char k = 'a'; k <= c; k++)
                    {
                        for (int l = 1; l <= d; l++)
                        {
                            for (int m = 1; m <= e; m++)
                            {
                                for (int n = 1; n <= f; n++)
                                {
                                    count++;

                                    if (count == N)
                                    {
                                        Console.WriteLine($"{i}{j}{k}{l}{m}{n}");
                                    }
                                    
                                }
                            }
                        }
                    }
                }
            }
            if (count < N)
            {
                Console.WriteLine("No password on this position");
            }
        }
    }
}
