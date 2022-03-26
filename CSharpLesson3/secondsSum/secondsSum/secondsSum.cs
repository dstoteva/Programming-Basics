using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondsSum
{
    class secondsSum
    {
        static void Main(string[] args)
        {
            int firstR = int.Parse(Console.ReadLine());
            int secondR = int.Parse(Console.ReadLine());
            int thirdR = int.Parse(Console.ReadLine());

            int time = firstR + secondR + thirdR;
            double timeInMin = time/60.0;
            int timeOne = time - 60;
            int timeTwo = time - 120;
            

            if (timeInMin<1&&time<10)   
                Console.WriteLine("0:0{0}", time);
            else if(timeInMin<1&&time>=10)
                Console.WriteLine("0:{0}", time);

            if (timeInMin >= 1 && timeInMin < 2 && (timeOne) < 10)
                Console.WriteLine("1:0{0}", timeOne);
            else if (timeInMin >= 1 && timeInMin < 2 && (timeOne) >= 10)
                Console.WriteLine("1:{0}", timeOne);

            if (timeInMin >= 2 && timeInMin < 3 && (timeTwo) < 10)
                Console.WriteLine("2:0{0}", timeTwo);
            else if (timeInMin >= 2 && timeInMin < 3 && (timeTwo) >= 10)
                Console.WriteLine("2:{0}", timeTwo);
        }
    }
}
