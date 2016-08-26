/*
Problem 2 – Angry Female GPS
Toshko says inappropriate mother words a lot. Every day, at least a hundred different kinds of curses come out of his mouth! This is so much that even his female voiced GPS got angry. It is normal, though… Most women do not like uncensored sentences! His GPS was named G PiSi – just for the reference it was coming not from GPS but from Gangsta PiSence – a very bad and notorious female voice.
One day while Toshko was driving and cursing, and driving and cursing, and driving and cursing, and driving and cursing, and driving and cursing, G Pisi’ s had enough of all the driving and cursing. So she decided (being bad and evil technology) to give Toshko wrong and random path directions. This is the algorithm: G Pisi calculates a random integer number then finds the sum of the even digits and the sum of the odd digits in it. Afterwards she compares these sums and according to the result she gives Toshko a direction.
•	If the sum of the even digits is bigger than the sum of the odd ones she gives him right direction.
•	If the sum of the odd digits is bigger than the sum of the even ones she gives him left direction.
•	If the two sums are equal she gives him straight direction.
For example G PiSi generates the integer 4729 so the sum of the even digits is 4 + 2 = 6 and the sum of the odd digits is 7 + 9 = 16. As a result the sum of the odd digits is bigger and the direction is left. 
Write a program that determines what kind of direction G Pisi would give Toshko by given integer number N and display the sum of the digits that leads to G Pisi’s choice.
Input
The input data should be read from the console. 
The only input line contains the integer number N which G Pisi generate at random. 
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data should be printed on the console. 
The output consists of one line. On the only output line you must print the kind of direction (“right”, “left” or “straight”) and the sum of the digits that leads to the choice separated by a single white space (e.g. “left 12”).
Constraints
•	N will be valid long number.
•	Allowed working time for your program: 0.1 seconds.
•	Allowed memory: 16 MB.
Examples
Input	Output		Input	Output
4729	left 16		112	straight 2

 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2.Angry_Female_GPS
{
    class AngryFemaleGPS
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());

            long number = N;
            if (N < 0)
            {
                //number = N * (-1);
                number = -N;
            }
            
            long sumOddDigits = 0L;
            long sumEvenDigits = 0L;
            
            //Summs processor
            for (int i = 0; i < N.ToString().Length; i++)
            {
                int reminder = (int)(number % 10L);
                number /= 10;

                bool isEven = (reminder % 2 == 0);
                bool isOdd = (reminder % 2 == 1);

                if (isEven)
                {
                    sumEvenDigits += reminder;
                }
                if (isOdd)
                {
                    sumOddDigits += reminder;
                }
            }

            //Directions processor
            string outputMsg = "";
            long outputSum = 0;
            if ((sumEvenDigits - sumOddDigits) > 0)
            {
                //right
                outputMsg = "right";
                outputSum = sumEvenDigits;
            }
            else if ((sumEvenDigits - sumOddDigits) < 0)
            {
                //left
                outputMsg = "left";
                outputSum = sumOddDigits;
            }
            else
            {
                //straight
                outputMsg = "straight";
                outputSum = sumEvenDigits;
            }

            //Print out
            Console.WriteLine("{0} {1}", outputMsg, outputSum);
        }
    }
}
