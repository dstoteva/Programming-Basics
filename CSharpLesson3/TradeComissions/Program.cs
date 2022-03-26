using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double result = -1;

            if (sales>=0 && sales<=500)
            {
                switch (town)
                {
                    case "Sofia":
                        result = sales * 5 / 100;
                        break;
                    case "Varna":
                        result = sales * 4.5 / 100;
                        break;
                    case "Plovdiv":
                        result = sales * 5.5 / 100;
                        break;
                }
            }
            else if (sales>500 && sales<=1000)
            {
                switch (town)
                {
                    case "Sofia":
                        result = sales * 7 / 100;
                        break;
                    case "Varna":
                        result = sales * 7.5 / 100;
                        break;
                    case "Plovdiv":
                        result = sales * 8 / 100;
                        break;
                }
            }
            else if(sales>1000 && sales<=10000)
            {
                switch (town)
                {
                    case "Sofia":
                        result = sales * 8 / 100;
                        break;
                    case "Varna":
                        result = sales * 10 / 100;
                        break;
                    case "Plovdiv":
                        result = sales * 12 / 100;
                        break;
                }
            }
            else if(sales > 10000)
            {
                switch (town)
                {
                    case "Sofia":
                        result = sales * 12 / 100;
                        break;
                    case "Varna":
                        result = sales * 13 / 100;
                        break;
                    case "Plovdiv":
                        result = sales * 14.5 / 100;
                        break;
                }
            }

            if (result == -1||sales<0)
                Console.WriteLine("error");
            else Console.WriteLine("{0:f2}", result);

        }
    }
}
