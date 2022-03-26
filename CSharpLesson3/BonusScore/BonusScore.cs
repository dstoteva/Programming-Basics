using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double bonus1=0;
            double bonus2=0;

            

            if (num <= 100)
                bonus1 = 5;
            else if (num > 100 && num <= 1000)
                bonus1 = (0.2 * num);
            else if (num > 1000)
                bonus1 = (0.1 * num);

            if (num % 2 == 0)
                bonus2 = 1;
            else if (num % 5 == 0)
                bonus2 = 2;

            double bonus = bonus1 + bonus2;
            double totalPoints = num + bonus;

            Console.WriteLine(bonus);
            Console.WriteLine(totalPoints);



        }
    }
}
