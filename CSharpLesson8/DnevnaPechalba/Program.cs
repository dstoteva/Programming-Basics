using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnevnaPechalba
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double kurs = double.Parse(Console.ReadLine());

            double monthSalary = n * m;
            double bonus = 2.5 * monthSalary;
            double yearMoney = (monthSalary * 12 + bonus);
            double allMoney = yearMoney *(75.0 / 100);
            double moneyInLeva = allMoney * kurs;
            double moneyADay = moneyInLeva / 365;

            Console.WriteLine($"{moneyADay:F2}");

        }
    }
}
