using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            int Weekends = 48;

            int daysInSofia = Weekends - h;
            double games = daysInSofia - (1.0 /4)*daysInSofia + (2.0/3)*p + h;

            if (year == "normal")
                Console.WriteLine(Math.Truncate(games));
            else if (year == "leap")
            {
                games = games + (15.0 / 100) * games;
                Console.WriteLine(Math.Truncate(games));
            }

        }
    }
}
