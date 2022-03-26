using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGNtoUSD
{
    class BGNtoUSD
    {
        static void Main(string[] args)
        {
            double lev = double.Parse(Console.ReadLine());
            double dollar = lev / 1.79549;

            Console.WriteLine(dollar);
        }
    }
}
