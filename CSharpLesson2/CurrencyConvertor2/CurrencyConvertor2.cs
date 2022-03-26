using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConvertor2
{
    class CurrencyConvertor2
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());
            string inPrice = Console.ReadLine();
            string outPrice = Console.ReadLine();
            double result = 0.0;

            switch(inPrice)
            {
                case "BGN":
                    result = value * 1.0;
                    break;
                case "USD":
                    result = value * 1.79549;
                    break;
                case "EUR":
                    result = value * 1.95583;
                    break;
                case "GBP":
                    result = value * 2.53405;
                    break;
            }
            switch(outPrice)
            {
                case "BGN":
                    result = result / 1.0;
                    break;
                case "USD":
                    result = result / 1.79549;
                    break;
                case "EUR":
                    result = result / 1.95583;
                    break;
                case "GBP":
                    result = result / 2.53405;
                    break;
            }
            Console.WriteLine("{0:f2} {1}", result, outPrice);
        }
    }
}
