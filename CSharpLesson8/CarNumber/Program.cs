using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int begin = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = begin; i <= end; i++)
            {
                for (int j = begin; j <= end; j++)
                {
                    for (int k = begin; k <= end; k++)
                    {
                        for (int l = begin; l <= end; l++)
                        {
                            if ((i % 2 == 0 && l % 2 !=0) || (i % 2 != 0 && l % 2 == 0))
                            {
                                if (i>l)
                                {
                                    if ((j+k)%2==0)
                                    {
                                        Console.Write($"{i}{j}{k}{l} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
