using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************************************************************************
    Play card

    Description

    Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints "yes CONTENT_OF_STRING" if it is a valid card sign or "no CONTENT_OF_STRING" otherwise.

    Input

    On the only line you will receive a single string.
    Output

    Output "yes CONTENT_OF_STRING" if the string is a card sign, otherwise print "no CONTENT_OF_STRING".
    Constraints

    String length will always be between 1 and 5
    Time limit: 0.1s
    Memory limit: 16MB
    Sample tests

Input	Output
5	yes 5
1	no 1
Q	yes q
q	no q
P	no P
10	yes 10
500	no 500 
     
********************************************************************************/

namespace P03.Check_for_a_Play_Card 
{
    class CheckForAPlayCard
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] cards = new string[17];
            cards[0] = "2";
            cards[1] = "3";
            cards[2] = "4";
            cards[3] = "5";
            cards[4] = "6";
            cards[5] = "7";
            cards[6] = "8";
            cards[7] = "9";
            cards[8] = "10";
            cards[9] = "J";
            cards[10] = "";
            cards[11] = "Q";
            cards[12] = "";
            cards[13] = "K";
            cards[14] = "";
            cards[15] = "A";
            cards[16] = "";

            bool isCard = cards.Contains(input);
            if (isCard)
            {
                Console.Write("yes ");
            }
            else
            {
                Console.Write("no ");
            }
            Console.WriteLine("{0}", input);

        }
    }
}
