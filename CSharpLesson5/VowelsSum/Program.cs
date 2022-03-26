using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int totalSum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char currentLetter = text[i];

                switch (currentLetter)
                {
                    case 'a':
                        totalSum += 1;
                        break;
                    case 'e':
                        totalSum += 2;
                        break;
                    case 'i':
                        totalSum += 3;
                        break;
                    case 'o':
                        totalSum += 4;
                        break;
                    case 'u':
                        totalSum += 5;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(totalSum);
        }
    }
}
