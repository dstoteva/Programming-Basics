using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int control = int.Parse(Console.ReadLine());

            int sum = 0;
            bool isTrue = true;
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = m; j >= 1; j--)
                {
                    count++;
                    sum += i * 2 + j * 3;

                    if (sum>=control)
                    {
                        Console.WriteLine($"{count} moves");
                        Console.WriteLine($"Score: {sum} >= {control}");
                        isTrue = false;
                        break;
                    }
                }
                if (isTrue == false)
                {
                    break;
                }
            }
            if (isTrue == true)
            {
                Console.WriteLine($"{count} moves");

            }

        }
    }
}
