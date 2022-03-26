using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int workDays = int.Parse(Console.ReadLine());

            int workHours = workers * workDays * 8;

            if (workHours>=hoursNeeded)
            {
                int hoursLeft = workHours - hoursNeeded;
                Console.WriteLine($"{hoursLeft} hours left");
            }
            else
            {
                int hoursOver = hoursNeeded - workHours;
                int penalties = hoursOver * workDays;
                Console.WriteLine($"{hoursOver} overtime");
                Console.WriteLine($"Penalties: {penalties}");
            }
        }
    }
}
