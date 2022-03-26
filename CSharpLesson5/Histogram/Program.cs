using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int p1Count = 0;
            int p2Count = 0;
            int p3Count = 0;
            int p4Count = 0;
            int p5Count = 0;

            for (int i = 0; i < n; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());

                count++;

                if (inputNumber < 200)
                    p1Count++;
                else if (inputNumber >= 200 && inputNumber < 400)
                    p2Count++;
                else if (inputNumber >= 400 && inputNumber < 600)
                    p3Count++;
                else if (inputNumber >= 600 && inputNumber < 800)
                    p4Count++;
                else
                    p5Count++;
            }

            double p1 = (double)p1Count / (double)count * 100;
            double p2 = (double)p2Count / (double)count * 100;
            double p3 = (double)p3Count / (double)count * 100;
            double p4 = (double)p4Count / (double)count * 100;
            double p5 = (double)p5Count / (double)count * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
