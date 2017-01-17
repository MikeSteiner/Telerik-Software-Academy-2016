using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Labirint
{
    class GameLabirint
    {
        static void Main(string[] args)
        {
            const char player = 'P';
            string[] maze = new string[]
            {
                "mmmmmmmmmmmmmmmm",
                "mmmmmmmmmmmmmmmm",
                "mmmmmmmmmmmmmmmm",
                "mmmmmmmmmmmmmmmm",
                "mmmmmmmmmmmmmmmm",
                "mmmmmmmmmmmmmmmm",
                "mmmmmmmmmmmmmmmm"
            };

            //Console prepare
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.White;
            //Console.SetCursorPosition(0, 6);
            //Console.WriteLine(player);       

            //Timer
            bool timeElapsed = false;
            Stopwatch endGameTimer = new Stopwatch();
            endGameTimer.Start();
            Console.SetCursorPosition(2, 7);
            Console.WriteLine(endGameTimer.Elapsed);

            timeElapsed = endGameTimer.Elapsed.Seconds > 65;
            if (timeElapsed)
            {
                endGameTimer.Stop();
            }

            //Play cyckle prepare
            int playerX = 0;
            int playerY = 7;
            int counter = 10;
            bool exitGame = false;
            

            while (true)
            {
                //Exit game
                if (exitGame || (counter == -100) || timeElapsed)
                {
                    break;
                }

                //Map print
                Console.SetCursorPosition(0, 0);
                Console.WriteLine(string.Join(Environment.NewLine, maze));
                
                //Left Right restriction
                if(playerX < 0)
                {
                    playerX = 0;
                } else if (playerX >= maze[0].Length)
                {
                    playerX = maze[0].Length-1;
                }
                //Top Down restriction
                if (playerY < 0)
                {
                    playerY = 0;
                }
                else if (playerY >= maze.Count())
                {
                    playerY = maze.Count() - 1;
                }
                //Player print
                Console.SetCursorPosition(playerX, playerY);
                Console.WriteLine(player);

                //Read key
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        playerY--;
                        break;
                    case ConsoleKey.DownArrow:
                        playerY++;
                        break;
                    case ConsoleKey.RightArrow:
                        playerX++;
                        break;
                    case ConsoleKey.LeftArrow:
                        playerX--;
                        break;
                    case ConsoleKey.Escape:
                        exitGame = true;
                        break;
                    default:
                        break;
                }

                Console.SetCursorPosition(0, maze.Count() + 1);
                
                counter--;
            }

        }                
    }
}
