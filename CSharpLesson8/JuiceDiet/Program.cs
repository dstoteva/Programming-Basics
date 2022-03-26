using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuiceDiet
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int juice = int.Parse(Console.ReadLine());

            int rCount = 0;
            int sCount = 0;
            int cCount = 0;
            double totalJuice = 0;


            for (int i = 0; i <= c; i++)
            {
                for (int j = 0; j <= s; j++)
                {
                    for (int k = 0; k <= r; k++)
                    {

                        double currentJuice = i * 15 + j * 7.5 + k* 4.5;

                        if (currentJuice <= juice)
                        {
                            if (currentJuice > totalJuice)
                            {
                                totalJuice = currentJuice;
                            }
                            if (currentJuice>=totalJuice)
                            {
                                cCount = i;
                                sCount = j;
                                rCount = k;
                            }
                        }
                    }
                }
            }

            
            Console.WriteLine($"{rCount} Raspberries, {sCount} Strawberries, {cCount} Cherries. Juice: {totalJuice} ml.");
        }
    }
}
