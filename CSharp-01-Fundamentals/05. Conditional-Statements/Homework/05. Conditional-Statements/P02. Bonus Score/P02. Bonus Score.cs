using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************************************************************************
    Bonus Score

    Description

    Write a program that applies bonus score to given score in the range [1…9] by the following rules:

    If the score is between 1 and 3, the program multiplies it by 10.
    If the score is between 4 and 6, the program multiplies it by 100.
    If the score is between 7 and 9, the program multiplies it by 1000.
    If the score is less than 0 or more than 9, the program prints "invalid score".
    Input

    The only input line will contain one integer number - the score
    Output

    Output the score with the applied bonus
    Constraints

    The score will always be a valid integer number
    Time limit: 0.1s
    Memory limit: 16MB
    Sample tests

Input	Output
2	20
4	400
9	1000
10	invalid score
Submission
     
********************************************************************************/
namespace P02.Bonus_Score
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());

            if (score >= 1 && score <= 3)
            {
                score = score * 10;
                Console.WriteLine("{0}", score);
            }
            else if (score >= 4 && score <= 6)
            {
                score = score * 100;
                Console.WriteLine("{0}", score);
            }
            else if (score >= 7 && score <= 9)
            {
                score = score * 1000;
                Console.WriteLine("{0}", score);
            }
            else
            {
                Console.WriteLine("invalid score");
            }
        }
    }
}
