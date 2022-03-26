using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelenieBezOstatyk
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int p1Count = 0;
            int p2Count = 0;
            int p3Count = 0;

            for (int i=0; i<n; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());

                if (inputNumber % 2 == 0)
                    p1Count++;
                if (inputNumber % 3 == 0)
                    p2Count++;
                if (inputNumber % 4 == 0)
                    p3Count++;
            }

            double p1Result = (double)p1Count / (double)n * (double)100;
            double p2Result = (double)p2Count / (double)n * (double)100;
            double p3Result = (double)p3Count / (double)n * (double)100;

            Console.WriteLine($"{p1Result:F2}%");
            Console.WriteLine($"{p2Result:F2}%");
            Console.WriteLine($"{p3Result:F2}%");
        }
    }
}
