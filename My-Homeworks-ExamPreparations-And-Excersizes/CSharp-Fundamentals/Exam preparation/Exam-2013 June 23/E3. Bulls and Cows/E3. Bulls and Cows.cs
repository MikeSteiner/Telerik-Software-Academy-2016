/*
    Problem 3 – Bulls and Cows
    All we love the “Bulls and Cows” game (http://en.wikipedia.org/wiki/Bulls_and_cows). Given a 4-digit secret number and a 4-digit guess number we say that we have b bulls and c cows when we have b matching digits on their right positions (bulls) and c matching digits on different positions (cows). Examples are given below:
    Secret number	1	4	8	1	Bulls  = 1
    Cows = 2		Secret number	2	2	4	9	Bulls  = 0
    Cows = 3
    Guess number	8	8	1	1			Guess number	9	9	2	4	
    Given the secret number and the number of bulls and cows your task is to write a program to find all matching guess numbers in increasing order.
    Input
    The input data should be read from the console. It will consist of exactly 3 lines. At the first line there the secret number will be given. At the second line the number of bulls b will be given. At the third line the number of cows c will be given.
    The input data will always be valid and in the format described. There is no need to check it explicitly.
    Output
    The output data should be printed on the console. It should consist of a single line holding all matched guess numbers, given in increasing order, separated by single space.
    Constraints
    •	The secret number will always consist of exactly 4 digits, each in the range [1…9].
    •	The numbers b and c will be in the range [0…9].
    •	Allowed working time for your program: 0.15 seconds.
    •	Allowed memory: 4 MB.

Examples
Input	Output		Input	Output		Input	Output
2228
2
1	1222 2122 2212 2232 2242 2252 2262 2272 2281 2283 2284 2285 2286 2287 2289 2292 2322 2422 2522 2622 2722 2821 2823 2824 2825 2826 2827 2829 2922 3222 4222 5222 6222 7222 8221 8223 8224 8225 8226 8227 8229 9222		1234
3
0	1134 1214 1224 1231 1232 1233 1235 1236 1237 1238 1239 1244 1254 1264 1274 1284 1294 1334 1434 1534 1634 1734 1834 1934 2234 3234 4234 5234 6234 7234 8234 9234		1234
3
1	No


 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3.Bulls_and_Cows
{
    class Program
    {
        public static int[] bullsAndCowsCout(int secretNumber, int guessNumber, int secretNumberLenght = 4)
        {
            int[] bullsCows = {0, 0};       //Array contains the bulls and the cows counter bc[0] = Bulls counted, bc[1] = Cows counted
            StringBuilder secretNumberSB = new StringBuilder("0000");
            StringBuilder guessNumberSB = new StringBuilder("0000");

            //Count all bulls and reset the counted
            int bullsCouter = 0;
            int sNumBulls = secretNumber;
            int gNumBulls = guessNumber;
            for (int i = 0; i < secretNumberLenght; i++)
            {
                int secretNumReminder = sNumBulls % 10;
                int guessNumReminder = gNumBulls % 10;
                bool isBull = (secretNumReminder == gNumBulls % 10);
                sNumBulls = sNumBulls / 10;
                gNumBulls = gNumBulls / 10;

                if (isBull)
                {
                    //secretNumSB[i] = '0';
                    bullsCouter++;
                }
                else
                {
                    //Secret number
                    //char[] chSN = secretNumReminder.ToString().ToCharArray();                    
                    //secretNumberSB[i] = chSN[0];
                    secretNumberSB[i] = Convert.ToChar(secretNumReminder.ToString());
                    //Guess number
                    char[] chGN = guessNumReminder.ToString().ToCharArray();
                    guessNumberSB[i] = chGN[0];
                }
            }
            bullsCows[0] = bullsCouter;


            //Count all cows and reset the counted
            int cowsCouter = 0;
            //string guessNumberStr = guessNumber.ToString();
            for (int i = 0; i < secretNumberLenght; i++)
            {
                if(guessNumberSB[i] == '0')
                {
                    continue;
                }

                for (int j = 0; j < secretNumberLenght; j++)
                {
                    if (guessNumberSB[i] == '0')
                    {
                        continue;
                    }
                    bool isCow = guessNumberSB[i].Equals(secretNumberSB[j]);
                    if (isCow)
                    {
                        secretNumberSB[j] = '0';
                        guessNumberSB[i] = '0';
                        cowsCouter++;
                        break;
                    }
                }
            }
            bullsCows[1] = cowsCouter;


            return bullsCows;
        }

        static void Main(string[] args)
        {
            int secretNum = int.Parse(Console.ReadLine());
            int bulls = int.Parse(Console.ReadLine());
            int cows = int.Parse(Console.ReadLine());
            
            int[] guessNum = { 1222, 2122, 2212, 2232, 2242 };
            List<int> bullsCowsMatches = new List<int>();

            for (int i = 1111; i <= 9999; i++)
            {
                string iStr = i.ToString();
                if (iStr.Contains("0"))
                {
                    continue;
                }

                int[] bc = bullsAndCowsCout(secretNum, i);                
                
                bool isBullsCowsMatch = (bulls == bc[0]) && (cows == bc[1]);
                if (isBullsCowsMatch)
                {
                    bullsCowsMatches.Add(i);
                }
            }

            //Print out
            if (bullsCowsMatches.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                foreach (var bc in bullsCowsMatches)
                {
                    Console.Write("{0} ", bc);
                }
            }       
        }
    }
}
