using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombineNameAge
{
    class CombineNameAge
    {
        static void Main(string[] args)
        {
            //“You are "firstName"; "lastName", a "age"-years old person from "town"”.
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();

            Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", firstName, lastName, age, town );

        }
    }
}
