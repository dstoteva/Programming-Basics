using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {

            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());

            int minutePlus = minute + 15;

            if (minutePlus > 59)
            {
                hour++;
                minutePlus = minutePlus - 60;
            }
            if (hour > 23)
                hour = hour - 24;

            if(minutePlus < 10)
                Console.WriteLine("{0}:0{1}", hour, minutePlus);
            else
                Console.WriteLine("{0}:{1}", hour, minutePlus);
        }
    }
}
