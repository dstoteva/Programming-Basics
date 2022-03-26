using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday
{
    class Birthday
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int depth = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int volume = length * width * depth;
            double volumeInLiters = volume * 0.001;
            double percentTaken = percent * 0.01;
            Console.WriteLine($"{volumeInLiters*(1-percentTaken):f3}");
        }
    }
}
