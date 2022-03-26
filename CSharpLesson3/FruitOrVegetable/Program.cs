using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitOrVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            //banana, apple, kiwi, cherry, lemon и grapes
            //tomato, cucumber, pepper и carrot
            bool isFruit = name == "banana" ||name== "apple" ||name== "kiwi" ||name== "cherry" ||name== "lemon" ||name== "grapes";
            bool isVeg = name == "tomato" || name == "cucumber" || name == "pepper" || name == "carrot";


            if (isFruit)
                Console.WriteLine("fruit");
            else if (isVeg)
                Console.WriteLine("vegetable");
            else
                Console.WriteLine("unknown");

        }
    }
}
