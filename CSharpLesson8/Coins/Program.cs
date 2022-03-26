using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            int moneyInStotiki = (int)(n*100);
            int stotici = moneyInStotiki % 10;
            moneyInStotiki /= 10;
            int desetici = moneyInStotiki % 10;
            moneyInStotiki /= 10;
            int edinici = moneyInStotiki;

            int count = 0;


            while (true)
            {
                if (stotici - 5 >= 0)
                {
                    stotici -= 5;
                    count++;
                }
                else if (stotici - 2 >= 0)
                {
                    stotici -= 2;
                    count++;
                }
                else if (stotici - 1 >= 0)
                {
                    stotici -= 1;
                    count++;
                }
                
            
                if (desetici - 5 >= 0)
                {
                    desetici -= 5;
                    count++;
                }
                else if (desetici - 2 >= 0)
                {
                    desetici -= 2;
                    count++;
                }
                else if (desetici - 1 >= 0)
                {
                    desetici -= 1;
                    count++;
                }
                
                 if (edinici - 2 >= 0)
                {
                    edinici -= 2;
                    count++;
                }
                else if (edinici - 1 >= 0)
                {
                    edinici -= 1;
                    count++;
                }

                if (edinici==0 && desetici==0 && stotici==0)
                {
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}
