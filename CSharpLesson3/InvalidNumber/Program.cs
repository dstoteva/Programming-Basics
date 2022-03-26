using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());

            if (!((i>=100 && i<=200)||i==0))
                Console.WriteLine("invalid");
        }
    }
}
