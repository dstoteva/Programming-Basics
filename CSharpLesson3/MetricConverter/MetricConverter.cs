using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class MetricConverter
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string inValue = Console.ReadLine(); 
            string outValue = Console.ReadLine();

            double inValueInMeters = 0;
            double outValueInMeters = 0;

            if (inValue == "m")
                inValueInMeters = num;
            else if (inValue == "mm")
                inValueInMeters = num / 1000;
            else if (inValue == "cm")
                inValueInMeters = num / 100;
            else if (inValue == "mi")
                inValueInMeters = num/ 0.000621371192;
            else if (inValue == "in")
                inValueInMeters = num / 39.3700787;
            else if (inValue == "km")
                inValueInMeters = num / 0.001;
            else if (inValue == "ft")
                inValueInMeters = num / 3.2808399;
            else if (inValue == "yd")
                inValueInMeters = num / 1.0936133;

            if (outValue == "m")
                outValueInMeters = inValueInMeters;
            else if (outValue == "mm")
                outValueInMeters = inValueInMeters * 1000;
            else if (outValue == "cm")
                outValueInMeters = inValueInMeters * 100;
            else if (outValue == "mi")
                outValueInMeters = inValueInMeters * 0.000621371192;
            else if (outValue == "in")
                outValueInMeters = inValueInMeters* 39.3700787;
            else if (outValue == "km")
                outValueInMeters = inValueInMeters * 0.001;
            else if (outValue == "ft")
                outValueInMeters = inValueInMeters * 3.2808399;
            else if (outValue == "yd")
                outValueInMeters = inValueInMeters * 1.0936133;

            Console.WriteLine("{0:f8}", outValueInMeters);
        }
    }
}
