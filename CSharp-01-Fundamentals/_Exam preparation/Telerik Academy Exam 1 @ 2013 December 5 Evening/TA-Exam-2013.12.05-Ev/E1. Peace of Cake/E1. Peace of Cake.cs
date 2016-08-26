/*
Problem 1 – Peace of Cake
In two towns there were living two different kinds of cakes. But not their color, not their size, not their taste was different. The problem was their pieces were not cut equally in the different cities. From generation to generation, they could not harmonize to each other. There could never be peace between the pieces just because of their lack of similarity. Yes, there is no mistake in the header of this task, as you thought while downloading it!
Anyway, it is your responsibility and duty to help the cakes become peaceful to each other before a third world war occurs on our planet cakearth. You will have to cut both towns’ cakes into smaller pieces so that they become equal. You will be a hero and a statue with your face will rise in the highest skies!
Back down, If you are not familiar with math fractions – shame on you, hero, but here it is an explanation! Fraction F/G consists of two parts – nominator (F) and denominator (G). The decimal value of every fraction is equal to the denominator dividing the nominator. For example the fraction 6/2 is equal to 3. Also on one given fraction you can multiply the nominator and the denominator by a number and the fraction’s value will not change. For example 1/3 is equal to 3/9. 
You are given two fractions A/B and C/D representing parts of the two types of cakes. A, B, C and D are always positive integers. 
You should calculate the total amount of cakes you have from the two cities. In other words your task is to find the sum between the two fractions of cakes. 
If you receive at least one complete full cake, you should calculate only the amount of full cakes from the result. For example 7/2 cakes are 3 cakes and a half. Your final result is 3. Otherwise, if you receive less than one full cake, you should calculate the decimal result, with exactly 22 digits after the decimal point - rounded. For example 2/3 cakes are equal to 0.6666666666666666666667 cakes as final result. In both cases you should calculate the fraction result with denominator equal to B * D. For example 3/5 + 1/2 = 11/10.
Input
The input data should be read from the console.
On the first input line you will receive the positive integer A.
On the second input line you will receive the positive integer B.
On the third input line you will receive the positive integer C.
On the fourth input line you will receive the positive integer D.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console.
If there is at least one complete cake, on the first output line you should print the amount of complete cakes.
Otherwise, on the first output line you should print the decimal result with exactly 22 digits after the decimal point.
On the second output line, you should print the final fraction result with denominator equal to B * D.

Constraints
•	A, B, C, D will be positive integers between 1 and 999 999, inclusive.
•	Allowed working time for your program: 0.10 seconds. Allowed memory: 16 MB.
Examples
Input example	Output example
3
5
1
2	

1
11/10

1
4
1
8	

0.3750000000000000000000
12/32

 */
using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1.PeaceofCake
{
    class PeaceOfCake
    {
        static void Main(string[] args)
        {   
            long A = long.Parse(Console.ReadLine());
            long B = long.Parse(Console.ReadLine());
            long C = long.Parse(Console.ReadLine());
            long D = long.Parse(Console.ReadLine());

            long nominator = A * D + C * B;
            long denominator = B * D;

            //decimal result = ((decimal)resultNominator / resultDenominator);
            decimal frABCB = ((decimal)nominator / (decimal)denominator);

            bool isMoreThanOneCace = (frABCB - 1.0m >= 0.0000000000000000000000001m);
        

            //if (frABCB >= 1.0m)
            if (isMoreThanOneCace)
            {
                //1
                //11 / 10
                Console.WriteLine((long)frABCB); //!!!!!!!!!!!!!!!!!!!               
            }
            else
            {
                //0.3750000000000000000000
                //12 / 32
                Console.WriteLine("{0:F22}", frABCB);

            }
            Console.WriteLine("{0}/{1}", nominator, denominator);
            
        }
    }
}
