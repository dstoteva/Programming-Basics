using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            

            int pieces = width * lenght;
            bool isTrue = false;
            int piecesTaken = 0;

            while (true)
            {
                string num = Console.ReadLine();

                if (num == "STOP")
                {
                    break;
                }

                else 
                {
                    piecesTaken = int.Parse(num);
                    pieces = pieces - piecesTaken;

                    if (pieces<0)
                    {
                       
                        Console.WriteLine($"No more cake left! You need {Math.Abs(pieces)} pieces more.");
                        isTrue = true;
                        break;
                    }
                    
                }

            }
            if (isTrue == false)
            {
                Console.WriteLine($"{pieces} pieces are left.");
            }

        }
    }
}
