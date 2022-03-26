using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int inputValue = int.Parse(Console.ReadLine());

                sum += inputValue;

                if (maxNumber < inputValue)
                    maxNumber = inputValue;
            }
            if((sum - maxNumber) == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum - maxNumber}");
            }
            else
            {
                int diff = Math.Abs(sum - 2*maxNumber);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
