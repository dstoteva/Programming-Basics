using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholMarket
{
    class AlcoholMarket
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerLiters = double.Parse(Console.ReadLine());
            double wineLiters = double.Parse(Console.ReadLine());
            double rakiqLiters = double.Parse(Console.ReadLine());
            double whiskeyLiters = double.Parse(Console.ReadLine());

            double rakiqPrice = whiskeyPrice / 2;    
            double winePrice = rakiqPrice - (0.4 * rakiqPrice);
            double beerPrice = rakiqPrice - (0.8 * rakiqPrice);

            double totalRakiqPrice = rakiqPrice * rakiqLiters;
            double totalWhiskeyPrice = whiskeyPrice * whiskeyLiters;
            double totalBeerPrice = beerLiters * beerPrice;
            double totalWinePrice = winePrice * wineLiters;

            double cost = totalRakiqPrice + totalWhiskeyPrice + totalBeerPrice + totalWinePrice;

            Console.WriteLine("{0:F2}", cost);



        }
    }
}
