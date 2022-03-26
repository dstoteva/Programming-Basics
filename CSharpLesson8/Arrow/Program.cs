using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int dashes = 4 + (n / 2 - 1);
            int dots = 0;
            int str8Dashes = 0;

            Console.Write(new string('_', dashes));
            Console.Write('^');
            Console.WriteLine(new string('_', dashes));

            dashes--;

            Console.Write(new string('_', dashes));
            Console.Write('/');
            Console.Write('|');
            Console.Write('\\');
            Console.WriteLine(new string('_', dashes));

            for (int i = 0; i < 4 + n/2; i++)
            {
                
            }
        }
    }
}
