using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcellentResult
{
    class ExcellentResult
    {
        static void Main(string[] args)
        {
            double note = double.Parse(Console.ReadLine());
            if(note>=5.50)
                Console.WriteLine("Excellent!");
            else
                Console.WriteLine("Not excellent.");
        }
    }
}
