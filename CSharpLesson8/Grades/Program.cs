using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            double topStudents = 0;
            double good = 0;
            double bad = 0;
            double fail = 0;
            double averageGrade = 0;

            for (int i = 0; i < students; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                averageGrade += grade;

                if (grade>=5 && grade<=6)
                {
                    topStudents++;
                }
                else if (grade>=4 && grade<5)
                {
                    good++;
                }
                else if (grade>=3 && grade<4 )
                {
                    bad++;
                }
                else if (grade<3)
                {
                    fail++;
                }
            }

            double topPercentage = topStudents / students*100;
            double goodPercentage = good / students*100;
            double badPercentage = bad / students*100;
            double failPercentage = fail / students*100;
            double averageGradePercentage = averageGrade / students;


            Console.WriteLine($"Top students: {topPercentage:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {goodPercentage:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {badPercentage:F2}%");
            Console.WriteLine($"Fail: {failPercentage:F2}%");
            Console.WriteLine($"Average: {averageGradePercentage:F2}");
        }
    }
}
