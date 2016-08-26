/*
Problem 1 – Next Date
We are given a date (day + month + year). Write a program to print the next day.
Input
The input data consists of 3 lines holding the integer numbers: day, month and year.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data should be printed on the console in the format day.month.year (no leading zeroes).
Constraints
•	The number day is in the range [1…31] inclusive.
•	The number month is in the range [1…12] inclusive.
•	The number year is in the range [2000…2013] inclusive.
•	The date is valid according to the classical calendar system.
•	Allowed work time for your program: 0.1 seconds.
•	Allowed memory: 16 MB.
Examples
Input	Output		Input	Output		Input	Output		Input	Output
1
11
2012	2.11.2012		30
9
2011	1.10.2011		28
2
2003	1.3.2003		31
12
2012	1.1.2013

 
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1.NextDate
{
    class NextDate
    {
        static void Main(string[] args)
        {
            //DateTime result = DateTime.ParseExact("2012-04-05", "yyyy-MM-dd", CultureInfo.InvariantCulture);   
            //DateTime enteredDate = DateTime.ParseExact(dt, "yyyy-MM-d", new CultureInfo("en-US"), DateTimeStyles.None);

            //*************** Variant one
            //string day = Console.ReadLine();
            //string month = Console.ReadLine();
            //string year = Console.ReadLine();
            //string dt = year + "-" + month.PadLeft(2,'0') + "-" + day.PadLeft(2,'0');

            //DateTime enteredDate = DateTime.ParseExact(dt, "yyyy-MM-d", CultureInfo.InvariantCulture);
            //DateTime nextDate = enteredDate.AddDays(1.0);
            //Console.WriteLine(nextDate.ToString("d.M.yyyy", CultureInfo.InvariantCulture));

            //*************** Variant two
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            DateTime enteredDate = new DateTime(year, month, day);
            DateTime nextDate = enteredDate.AddDays(1.0);
            Console.WriteLine(nextDate.ToString("d.M.yyyy", CultureInfo.InvariantCulture));

        }
    }
}
