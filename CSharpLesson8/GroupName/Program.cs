using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupName
{
    class Program
    {
        static void Main(string[] args)
        {
            char bigLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());
            char fourthLetter = char.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());

            int count = 0;

            for (char i = 'A'; i <= bigLetter; i++)
            {
                for (int j = 'a'; j <= secondLetter; j++)
                {   
                    for (int k = 'a'; k <= thirdLetter; k++)
                    {     
                        for (int l = 'a'; l <= fourthLetter; l++)
                        {
                            for (int m = 0; m <= number; m++)
                            {
                                count++;

                                if (i == bigLetter && j == secondLetter && k==thirdLetter && l==fourthLetter && m==number)
                                {
                                    Console.WriteLine(count - 1);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
