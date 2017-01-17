using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**************************************************************
    Print a Deck

    Description

    Write a program that reads a card sign(as a char) from the console and generates and prints all possible cards from a standard deck of 52 cards up to the card with the given sign(without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).

    The card faces should start from 2 to A.
    Print each card face in its four possible suits: clubs, diamonds, hearts and spades.
    Input

    On the only line, you will receive the sign of the card to which, including, you should print the cards in the deck.
    Output

    The output should follow the format bellow(assume our input is 5):  2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds 3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds ... 5 of spades, 5 of clubs, 5 of hearts, 5 of diamonds 
    Constraints

    The input character will always be a valid card sign.
    Time limit: 0.1s
    Memory limit: 16MB
    Sample tests

Input	Output
5	2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds
3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds
...
5 of spades, 5 of clubs, 5 of hearts, 5 of diamonds

**************************************************************/
namespace P04.Print_a_Deck
{
    class PrintDeck
    {
        static void Main(string[] args)
        {
            string cardNum = Console.ReadLine();
            
            Dictionary<string, List<string>> cards = new Dictionary<string, List<string>>();
            string[] cardsSigns = new string[]{ "spades", "clubs", "hearts", "diamonds" };

            
            for (int i = 2; i <= 10; i++)
            {
                cards.Add(i.ToString(), cardsSigns.ToList());
            }
            cards.Add("J", cardsSigns.ToList());     //Jack
            cards.Add("Q", cardsSigns.ToList());    //Queen
            cards.Add("K", cardsSigns.ToList());     //King
            cards.Add("A", new List<string> { "spades", "clubs", "hearts", "diamonds" }); //Ace

            foreach (var item in cards)
            {                
                string str = string.Join(", ", item.Value);
                str = " " + str;
                str = str.Replace(" ", item.Key+" of ");
                str = str.Replace(",", ", ");

                Console.WriteLine("{0}", str);

                if(cardNum.Equals(item.Key))
                {
                    break;
                }
            }
        }
    }
}
