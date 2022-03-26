using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char begin = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char skip = char.Parse(Console.ReadLine());

            int count = 0;

            for (char i = begin; i <= end; i++)
            {
                if (i == skip)
                {
                    continue;
                }

                for (char k = begin; k <= end; k++)
                {
                    if (k == skip)
                    {
                        continue;
                    }

                    for (char l = begin; l <= end; l++)
                    {
                        if (l==skip)
                        {
                            continue;
                        }
                        else
                        {
                            count++;
                            Console.Write($"{i}{k}{l} ");
                            
                        }

                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
