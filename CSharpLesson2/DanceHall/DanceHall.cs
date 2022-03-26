using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanceHall
{
    class DanceHall
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double wardrobeSide = double.Parse(Console.ReadLine());

            double hallAreaInCm = (length * 100) * (width * 100);
            double wardrobeSize = (wardrobeSide * 100) * (wardrobeSide * 100);
            double benchSize = hallAreaInCm / 10;
            double spaceLeft = hallAreaInCm - (wardrobeSize + benchSize);
            double danceCourt = spaceLeft / 7040;
            Console.WriteLine(Math.Floor(danceCourt));

        }
    }
}
