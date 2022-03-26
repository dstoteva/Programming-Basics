using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number0To100
{
    class number0To100
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            
                string firstNum = "";
                string secondNum = "";

            if (i >= 0 && i <= 100)
            {

                if (i < 20)
                {
                    switch (i)
                    {
                        case 0:
                            secondNum = "zero";
                            break;
                        case 1:
                            secondNum = "one";
                            break;
                        case 2:
                            secondNum = "two";
                            break;
                        case 3:
                            secondNum = "three";
                            break;
                        case 4:
                            secondNum = "four";
                            break;
                        case 5:
                            secondNum = "five";
                            break;
                        case 6:
                            secondNum = "six";
                            break;
                        case 7:
                            secondNum = "seven";
                            break;
                        case 8:
                            secondNum = "eight";
                            break;
                        case 9:
                            secondNum = "nine";
                            break;
                        case 10:
                            secondNum = "ten";
                            break;
                        case 11:
                            secondNum = "eleven";
                            break;
                        case 12:
                            secondNum = "twelve";
                            break;
                        case 13:
                            secondNum = "thirteen";
                            break;
                        case 14:
                            secondNum = "fourteen";
                            break;
                        case 15:
                            secondNum = "fifteen";
                            break;
                        case 16:
                            secondNum = "sixteen";
                            break;
                        case 17:
                            secondNum = "seventeen";
                            break;
                        case 18:
                            secondNum = "eigtheen";
                            break;
                        case 19:
                            secondNum = "nineteen";
                            break;
                    }
                    Console.WriteLine(secondNum);
                }
                else if (i == 100)
                    Console.WriteLine("one hundred");

                else
                {

                    string a = i.ToString();
                    string x = a.Substring(0, 1);
                    string y = a.Substring(1);




                    switch (y)
                    {
                        case "1":
                            secondNum = "one";
                            break;
                        case "2":
                            secondNum = "two";
                            break;
                        case "3":
                            secondNum = "three";
                            break;
                        case "4":
                            secondNum = "four";
                            break;
                        case "5":
                            secondNum = "five";
                            break;
                        case "6":
                            secondNum = "six";
                            break;
                        case "7":
                            secondNum = "seven";
                            break;
                        case "8":
                            secondNum = "eight";
                            break;
                        case "9":
                            secondNum = "nine";
                            break;
                    }

                    switch (x)
                    {
                        case "2":
                            firstNum = "twenty";
                            break;
                        case "3":
                            firstNum = "thirty";
                            break;
                        case "4":
                            firstNum = "forty";
                            break;
                        case "5":
                            firstNum = "fifty";
                            break;
                        case "6":
                            firstNum = "sixty";
                            break;
                        case "7":
                            firstNum = "seventy";
                            break;
                        case "8":
                            firstNum = "eighty";
                            break;
                        case "9":
                            firstNum = "ninety";
                            break;
                    }
                    if(y == "0")
                        Console.WriteLine(firstNum);
                    else
                        Console.WriteLine(firstNum + " " + secondNum);
                }
            }
            else
                Console.WriteLine("invalid number");
        }
    }
}
