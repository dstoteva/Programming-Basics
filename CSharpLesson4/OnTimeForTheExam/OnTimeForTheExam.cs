using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForTheExam
{
    class OnTimeForTheExam
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minuteExam = int.Parse(Console.ReadLine());
            int hourArrival = int.Parse(Console.ReadLine());
            int minuteArrival = int.Parse(Console.ReadLine());

            int exam = hourExam*60 + minuteExam;
            int arrival = hourArrival*60 + minuteArrival;

            int diff = Math.Abs(exam - arrival);

            int hour = diff / 60;
            int minute = diff % 60;


            if (exam < arrival)
            {
                Console.WriteLine("Late");

                if (diff <= 59)
                    Console.WriteLine("{0} minutes after the start", diff);

                else
                {

                    Console.WriteLine("{0}:{1:d2} hours after the start", hour, minute);
                }
            }


            else
            {
                if (diff <= 30)
                {
                    Console.WriteLine("On time");
                }
                else
                    Console.WriteLine("Early");

                if(diff<= 59)
                    Console.WriteLine("{0} minutes before the start", diff);
                else
                    Console.WriteLine("{0}:{1:d2} hours before the start", hour, minute);

            }
        }
    }
}
