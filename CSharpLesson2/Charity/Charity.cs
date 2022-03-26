using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity
{
    class Charity
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int cooks = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int wafers = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double money = days*cooks*(cakes * 45 + wafers * 5.80 + pancakes * 3.20);
            double allMoney = money - (money/8);
            Console.WriteLine("{0:f2}", allMoney);
        }
    }
}
