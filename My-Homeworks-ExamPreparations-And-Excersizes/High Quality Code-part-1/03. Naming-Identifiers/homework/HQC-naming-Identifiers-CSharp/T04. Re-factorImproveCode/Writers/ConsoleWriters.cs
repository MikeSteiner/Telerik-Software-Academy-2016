using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper.Writers
{
    public static class ConsoleWriters
    {
        public static void PrintAllPlayersRanking(string ranking)
        {
            Console.WriteLine("\nPoints:");
            Console.WriteLine(ranking);
            Console.WriteLine();
        }

        public static void PrintTheField(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);

            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);

                for (int j = 0; j < cols; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        public static void PrintOnExitMessage()
        {
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        public static void PrintString(string printString)
        {
            Console.WriteLine(printString);
        }
    }
}
