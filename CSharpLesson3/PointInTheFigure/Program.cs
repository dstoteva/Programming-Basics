using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInTheFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int x1 = 0;
            int y1 = h;
            int x2 = 3 * h;
            int y2 = 0;

            int x3 = h;
            int y3 = 4 * h;
            int x4 = 2 * h;
            int y4 = h;

            bool isInFigure1 = x > x1 && x < x2 && y > y2 && y < y1;
            bool isInFigure2 = x > x3 && x < x4 && y >= y4 && y < y3;

            bool isBorderFigure1 = (x == x1 && y <= y1 && y >= y2) || (x == x2 && y <= y1 && y >= y2) || (y == y2 && x >= x1 && x <= x2) || (y == y1 && x >= x1 && x <= x3) || (y==y1 && x>=x4 && x<=x2);
            bool isBorderFigure2 = (x == x3 && y <= y3 && y >= y4) || (x==x4 && y<=y3 && y>= y4) || (y == y3 && x >= x3 && x <= x4);

            if (isInFigure1 || isInFigure2)
                Console.WriteLine("inside");
            else if (isBorderFigure1 || isBorderFigure2)
                Console.WriteLine("border");
            else
                Console.WriteLine("outside");


        }
    }
}
