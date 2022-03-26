using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoNumbersSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int begin = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());

            int count = 0;
            bool isTrue = true;


            for (int i = begin; i >= end; i--)
            {
                for (int j = begin; j >= end; j--)
                {
                    count++;

                    if (i+j == magic)
                    {
                        Console.WriteLine($"Combination N:{count} ({i} + {j} = {magic})");
                        isTrue = false;
                    }
                    
                    

                }
                if (isTrue == false)
                {
                    break;
                }

            }

            if (isTrue==true)
            {
                Console.WriteLine($"{count} combinations - neither equals {magic}");
            }
        }
    }
}
