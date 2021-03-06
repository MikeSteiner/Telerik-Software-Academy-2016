﻿using System;
/*
    Problem 1 – Printing
    The first C# exam is coming! Help the trainers to calculate the amount of money they save for not printing on paper the exam descriptions. There are N students in the academy. The number of paper sheets that should be printed for each student is S. One realm (box with paper sheets) contains exactly 500 sheets of paper. The price of one realm is P.
    You can buy part of a realm. For example if the price of a realm is 2.20 you can buy 0.45 parts of one realm which means that you will pay 0.45 * 2.20 = 0.99.
    N, S, P should be read from the console. Output the exact total amount of money the trainers save for not printing the exams on paper. The output should be rounded with 2 digits after the decimal point.
    See the examples below for clarification.
    Input
    The input data should be read from the console.
    The number N will be given on the first console line.
    The number S will be given on the second console line.
    The number P will be given on the third console line.
    The input data will always be valid and in the format described. There is no need to check it explicitly.
    Output
    The output data should be printed on the console.
    Output the amount of money with precision 2 digits after the decimal point (Hint: use the formatting string {0:F2} for outputting the answer)
    Constraints
    •	N will be a positive integer between 1 and 10 000.
    •	S will be a positive integer between 1 and 500.
    •	P will be a positive number between 0.01 and 100 with precision 2 digits after the decimal point.
    •	Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.

Examples
Example input	Example output	Explanation
1100
5
4.80	52.80	1100 students with 5 sheets of paper each = total 5500 sheets of paper.
5500 sheets of paper means 11 reams.
11 reams with price of 4.80 each = 52.80
686
7
4.98	47.83
	686 students with 7 sheets of paper each = total 4802 sheets of paper.
4802 sheets of paper means 9.604 reams.
9.604 reams with price of 4.98 each = 47.83
Actually the exact result is 47.82792 but when rounded to the second digit after the decimal point we come up with 47.83

*/

namespace TA_Exam_2015._02_Morn
{
    class Printing
    {
        static void Main(string[] args)
        {
            const int sheetsInRealm = 500;
            int students = int.Parse(Console.ReadLine());
            int sheetsPerStudent = int.Parse(Console.ReadLine());
            double pricePerRealm = double.Parse(Console.ReadLine());

            int sheetsTotal = students * sheetsPerStudent;
            double realmsTotal = (double)sheetsTotal / (double)sheetsInRealm;

            double totalPrise = realmsTotal * pricePerRealm;
            Console.WriteLine("{0:#0.00}", totalPrise);

        }
    }
}
