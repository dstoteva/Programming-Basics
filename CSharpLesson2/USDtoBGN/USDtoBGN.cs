using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USDtoBGN
{
    class USDtoBGN
    {
        static void Main(string[] args)
        {
            double dollar = double.Parse(Console.ReadLine());
            double lev = dollar * 1.79549;

            Console.WriteLine("{0:f2} BGN", lev);
        }
    }
}
