/*
    Problem 3 – Card Wars Batka!
    Description
    Pesho and Gosho are best friends and they love to play card games. They have played all the card games in the world and now they are bored. So they decided to ask their friend Stamat to invent a new, fun, card game for them. After many, many sleepless night, Stamat invented a new card game called “Card Wars Batka!”. So here are the rules of this new card game:
    A game match consists of N games and in each game both players get 3 cards and each card has different point strength. Here is a table with all the cards and their point strength:
    Card	2	3	4	5	6	7	8	9	10	A	J	Q	K
    Points	10	9	8	7	6	5	4	3	2	1	11	12	13
    The goal of each game is to get a better hand strength than the other player. The hands strength is made by the sum of the points of each card in the hand, so if we have 5, A and Q, the hand strength is
    7 + 1 + 12 = 20.
    At the end of each game we check which hand strength is bigger and we choose a winner. Then we increase the player’s score with the amount of points his hand strength has. So if player one has 20 points hand strength and he wins the match – he has 20 points player score and if in his second game he has hand strength of 35 and he wins the match, his player score will be 20 + 35 = 55.
    Note: The player score can be negative.
    Only the winning player gets the points form his hand strength to his player score. If both players have equal hand strengths, then no one gets any points to their player scores and the game does not count as “won” for either of them.
    But wait, there is more and more!
    Stamat added to the game 3 more special cards! So here is a list of them and what they do:
    -	The “Z” card – doubles the current player's score. The card can be drawn more than once in the same hand (2 times drawn  player score * 4; 3 times drawn  player score * 8).
    -	The “Y” card – subtracts 200 from the player's score. The card can be drawn more than once in the same hand (2 times drawn  player score -400; 3 times drawn  player score -600).
    -	The “X” card – wins the whole game match, BUT if both players draw the “X” card in the same game, they are both awarded 50 points to their player score (without any one of them winning the game). It doesn’t matter if the card is drawn 2 or 3 times in the same hand.
    At the end of each game match your program should print these exact messages on the console in these cases:
    Condition	Message	Comments
    If player one has drawn “X” card	X card drawn! Player one wins the match!	The first player wins.
    If player two has drawn the “X” card	X card drawn! Player two wins the match!	The second player wins.
    If player one has a bigger player score than player two	First player wins!
    Score: S
    Games won: G	S is the score of the first player. The games won by the first player is G.
    If player two has a bigger player score than player one	Second player wins!
    Score: S
    Games won: G	S is the score of the second player. The games won by the second player is G.
    If player score of the first and the second player are equal	It's a tie!
    Score: S	Where S is the score of both players.
    Input
    The input data should be read from the console.
    At the first line you are given the number of games in a match (N). So if we are given 5, there will be 5 games in this match.
    At the next 3 lines we are given the 3 cards for the first player hand, and after that at the next 3 lines we are given the 3 cards for the second player hands. The 3 + 3 line model is repeated N times where N is the number of games.
    The input data will always be valid and in the format described. There is no need to check it explicitly.
    Output
    The output data should be printed on the console.
    AT the standard output your program should print an appropriate message with the exact letters casing.
    Constraints
    •	The number N is in the range [1…100] inclusive.
    •	Allowed working time for your program: 0.1 seconds.
    •	Allowed memory: 16 MB.
Examples
Input	Output		Input	Output		Input	Output		Input	Output
2
2
2
2
A
A
5
2
K
2
5
6
A	First player wins!
Score: 63
Games won: 2		1
10
10
10
K
Q
J	Second player wins!
Score: 36
Games won: 1		1
K
Q
J
10
X
10	X card drawn! Player two wins the match!		2
A
A
A
A
A
A
A
A
A
A
A
A	It's a tie!
Score: 0
 
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3.Card_Wars
{
    class CardWars
    {
        public static int CardsAnalyse(int[] playerThisHand)
        {
            //Player One cards analyse
            int score = 0;
            for (int ca = 0; ca < playerThisHand.Length; ca++)
            {
                if (playerThisHand[ca] > 0)
                {
                    score = score + playerThisHand[ca];
                }
                else
                {
                    // Z card
                    if (playerThisHand[ca] == (-1))
                    {
                        score = score * 2;
                    }
                    // Y card
                    else if (playerThisHand[ca] == (-2))
                    {
                        score = score - 200;
                    }
                    else if (playerThisHand[ca] == (-3))
                    {
                        score = score + 50;
                    }
                }
            }
            return score;

        }


        static void Main(string[] args)
        {
            const int cardsPerHand = 3;

            //** Define cards and points
            Dictionary<string, int> cardsPoint = new Dictionary<string, int>
            {
                {"2", 10},
                {"3", 9},
                {"4", 8},
                {"5", 7},
                {"6", 6},
                {"7", 5},
                {"8", 4},
                {"9", 3},
                {"10", 2},
                {"A", 1},
                {"J", 11},
                {"Q", 12},
                {"K", 13},
                {"Z", -1},
                {"Y", -2},
                {"X", -3}

            };

            //** Input data
            //Total games to play
            int N = int.Parse(Console.ReadLine());

            //Declare hands
            int[] playerOneThisHand = new int[3];
            int[] playerTwoThisHand = new int[3];
            int playerOneTotalScore = 0;
            int playerTwoTotalScore = 0;

            int playerOneHandsWon = 0;
            int playerTwoHandsWon = 0;

            bool playerOneWinsGame = false;
            bool playerTwoWinsGame = false;

            bool xCardWins = false;
            bool normalWin = false;
            bool isTie = false;


            string outputMessage = "";
            int outputScore = 0;
            int outputGamesWon = 0;

            //Games
            for (int i = 0; i < N; i++)
            {
                //Player One full out hand
                for (int h = 0; h < cardsPerHand; h++)
                {
                    string pOneCard = Console.ReadLine();
                    if (pOneCard == "X")
                    {
                        playerOneWinsGame = true;                        
                    }
                    int result;
                    if (cardsPoint.TryGetValue(pOneCard, out result))
                    {
                        playerOneThisHand[h] = result;
                    }
                    else
                    {
                        playerOneThisHand[h] = -4;
                    }
                }

                //Player Two full out hand
                for (int h = 0; h < cardsPerHand; h++)
                {
                    string pTwoCard = Console.ReadLine();
                    if (pTwoCard == "X")
                    {
                        playerTwoWinsGame = true;                        
                    }

                    playerTwoThisHand[h] = cardsPoint[pTwoCard];
                }

                //Curretn hand analysis
                if (playerOneWinsGame && !playerTwoWinsGame)
                {
                    outputMessage = "X card drawn! Player one wins the match!";
                    xCardWins = true;
                    //Console.WriteLine(outputMessage);
                    break;
                }
                else if (!playerOneWinsGame && playerTwoWinsGame)
                {
                    outputMessage = "X card drawn! Player two wins the match!";
                    xCardWins = true;
                    //Console.WriteLine(outputMessage);
                    break;
                }
                else
                {
                    //Hands strenght analyser
                    int playerOneThisHandStrenght = CardsAnalyse(playerOneThisHand);
                    int playerTwoThisHandStrenght = CardsAnalyse(playerTwoThisHand);

                    if (playerOneThisHandStrenght > playerTwoThisHandStrenght)
                    {
                        playerOneTotalScore = playerOneTotalScore + CardsAnalyse(playerOneThisHand);
                        playerOneHandsWon++;
                    }
                    else if (playerOneThisHandStrenght < playerTwoThisHandStrenght)
                    {
                        playerTwoTotalScore = playerTwoTotalScore + CardsAnalyse(playerTwoThisHand);
                        playerTwoHandsWon++;
                    }
                    else if((playerOneThisHandStrenght == playerTwoThisHandStrenght) && playerOneWinsGame && playerTwoWinsGame)                        
                    {
                        playerOneTotalScore = playerOneTotalScore + 50;
                        playerTwoTotalScore = playerTwoTotalScore + 50;
                    }

                    //Total score comparer
                    //Player one wins
                    if (playerOneTotalScore > playerTwoTotalScore)
                    {
                        outputMessage = "First player wins!";
                        outputScore = playerOneTotalScore;
                        outputGamesWon = playerOneHandsWon;

                        normalWin = true;
                    }
                    //Player one wins
                    else if (playerOneTotalScore < playerTwoTotalScore)
                    {
                        outputMessage = "Second player wins!";
                        outputScore = playerTwoTotalScore;
                        outputGamesWon = playerTwoHandsWon;

                        normalWin = true;
                    }
                    //Its a tie
                    else
                    {
                        outputMessage = "It's a tie!";
                        outputScore = playerOneTotalScore;
                        outputGamesWon = playerOneHandsWon;

                        isTie = true;
                    }
                }


            }

            //Normal exit
            if (xCardWins)
            {
                Console.WriteLine(outputMessage);
            }
            else if (isTie)
            {
                Console.WriteLine(outputMessage);
                Console.WriteLine("Score: {0}", outputScore);
            }
            else if (normalWin)
            {
                Console.WriteLine(outputMessage);
                Console.WriteLine("Score: {0}", outputScore);
                Console.WriteLine("Games won: {0}", outputGamesWon);
            }

            //Console.WriteLine(outputMessage);
            //if (!playerOneWinsGame && !playerTwoWinsGame)
            //{
            //    Console.WriteLine("Score: {0}", outputScore);
            //    if (!isTie)
            //    {
            //        Console.WriteLine("Games won: {0}", outputGamesWon);
            //    }

            //}
        }
    }
}