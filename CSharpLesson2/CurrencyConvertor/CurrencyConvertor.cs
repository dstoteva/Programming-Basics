using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConvertor
{
    class CurrencyConvertor
    {
        static void Main(string[] args)
        {
            double price = double.Parse(Console.ReadLine());
            string enteredValue = (Console.ReadLine());
            string convertedValue = (Console.ReadLine());
            double convertedPrice=0.0;

            double lev = 1;
            double dollar = 1.79549;
            double euro = 1.95583;
            double pound = 2.53405;

            if (enteredValue=="BGN")
            {
                if(convertedValue=="USD")
                    convertedPrice = price/dollar;
                if (convertedValue == "EUR")
                    convertedPrice = price/euro;
                if (convertedValue == "GBP")
                    convertedPrice = price/pound;
            }
            if (enteredValue == "USD")
            {
                if (convertedValue == "BGN")
                    convertedPrice = price * dollar;
                if (convertedValue == "EUR")
                    convertedPrice = price * dollar / euro;
                if (convertedValue == "GBP")
                    convertedPrice = price * dollar / pound;
            }
            if(enteredValue=="EUR")
            {
                if (convertedValue == "BGN")
                    convertedPrice = price * euro;
                if (convertedValue == "USD")
                    convertedPrice = price * euro / dollar;
                if (convertedValue == "GBP")
                    convertedPrice = price * euro / pound;
            }
            if(enteredValue=="GBP")
            {
                if (convertedValue == "BGN")
                    convertedPrice = price * pound;
                if (convertedValue == "EUR")
                    convertedPrice = price * pound / euro;
                if (convertedValue == "USD")
                    convertedPrice = price * pound / dollar;
            }
            Console.WriteLine("{0:f2} {1}", convertedPrice, convertedValue);
        }
    }
}
