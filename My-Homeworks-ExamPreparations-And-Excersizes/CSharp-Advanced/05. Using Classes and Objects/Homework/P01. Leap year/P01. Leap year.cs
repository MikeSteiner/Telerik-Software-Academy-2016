using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.P01.LeapYear
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());

            //int year;
            //year = 2016;    // Leap
            //year = 1996;    // Leap
            //year = 1900;    // Common
            //year = 2000;    // Leap
            //year = 681;     // Common
            //year = 3400;    // Common

            string yearLeapOrCommon = ChekLeapYear(year);
            Console.WriteLine(yearLeapOrCommon);
        }

        static string ChekLeapYear(int year)
        {
            bool isLeapYear = DateTime.IsLeapYear(year);
            if (isLeapYear)
            {
                return "Leap";
            }
            return "Common";
        }
    }
}
