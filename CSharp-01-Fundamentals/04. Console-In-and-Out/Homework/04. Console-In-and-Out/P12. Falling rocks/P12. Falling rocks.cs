
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edmos_FallingRocks
{

    /* Implement the "Falling Rocks" game in the text console. A small dwarf stays at
     * the bottom of the screen and can move left and right (by the arrows keys). A
     * number of rocks constantly fall down and you need to avoid a crash. There are gems too.
     */
}
/********************************************************************************************
    Falling Rocks
    Description

    Implement the "Falling Rocks" game in the text console.
    A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
    A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
    Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O).
    Ensure a constant game speed by Thread.Sleep(150).
    Implement collision detection and scoring system.
    console-falling-rocks

    Submission
*********************************************************************************************/
class FallingRocks
{
    struct Object
    {
        public int x;
        public int y;
        public ConsoleColor color;
        public string symbol;
        public bool collected;
        public int delay;
        public int dwarfLives;
    }
    //Method for printing objects and text 
    static void PrintObject(int x, int y, string symbol, ConsoleColor color = ConsoleColor.Red)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.WriteLine(symbol);
    }
    static void Main()
    {
        //Define the size of playfield
        int windowHeight = 42;  //50
        int windowWidth = 120;
        int playfieldWidth = 90; //from positions 0 to 90

        // We must remove the console scroll bar for the game (buffer is the scroll bar pointer)
        Console.BufferHeight = Console.WindowHeight = windowHeight;
        Console.BufferWidth = Console.WindowWidth = windowWidth;

        // Create the DWARF
        Object dwarf = new Object();
        dwarf.x = playfieldWidth / 2;
        dwarf.y = Console.WindowHeight - 1;   // (0 is on the top row of Console, hight-1 is the bottom row of Console,
        // point [0,0 ]is top-left of Console
        dwarf.color = ConsoleColor.DarkCyan;
        dwarf.symbol = ((char)2).ToString();
        dwarf.dwarfLives = 5; //we give the dwarf 5 lifes

        Random randomGenerator = new Random();//random genarator for falling rocks on random placies

        List<Object> listOfObjects = new List<Object>(); //empty list of objects

        //Here we create an empty Array for the gems (in the begining, there are no germs and we seting them to false)
        Object[] gem = new Object[7];
        for (int i = 0; i < 7; i++)
        {
            gem[i].collected = false;
        }

        Object gameSpeed = new Object();

        gameSpeed.delay = 250;
        PrintObject(30, 1, "TEAM *EDMOS* PRESENTS: << FALLING ROCKS >> ", ConsoleColor.Red);
        PrintObject(20, 4, "THE RULES: Help the DWARF to collect all 7 red gems and to avoid the rocks.\n                               You can move on only left or right", ConsoleColor.Yellow);
        PrintObject(45, 7, "GOOD LUCK!", ConsoleColor.Green);
        PrintObject(56, 7, ((char)2).ToString(), ConsoleColor.Yellow);

        PrintObject(5, 17, "           GEMS: \n\nNEW IDEA:                      " + (char)6 + "\nSUMMER TIME:                 "
                   + (char)15 + "\nPOWER:                         " + (char)5
                   + "\nLET'S SING:                  " + (char)14 + "\nCOMUNICATION:                  " + (char)64
                   + "\nLOVE C#:                     " + "C#" + "\nEDMOS' AWARD:              " + "EDMOS", ConsoleColor.Yellow);

        PrintObject(0, 31, "press [ENTER]  to play   \npress [ESCAPE] to exit", ConsoleColor.Cyan);

        ConsoleKeyInfo info = Console.ReadKey();
        if (info.Key == ConsoleKey.Escape)
        {
            return;
        }
        else
        {
            info = Console.ReadKey();
            if (info.Key == ConsoleKey.Enter)
            {
                while (true)
                {
                    //results
                    //Total sucssess - the DWARF collected all 7 gems

                    if (gem[0].collected && gem[1].collected && gem[2].collected && gem[3].collected
                           && gem[4].collected && gem[5].collected && gem[6].collected)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 200; j <= 3000; j += 400)
                            {
                                Console.Beep(j, 200);
                            }
                            Console.Beep(3400, 300);
                            Console.Beep(1000, 1000);
                        }


                        Console.Clear();
                        PrintObject(61, 6, ((char)2).ToString(), ConsoleColor.Yellow);

                        PrintObject(55, 10, "I AM THE BEST!", ConsoleColor.Cyan);
                        PrintObject(52, 12, "THANKS FOR YOUR HELP!", ConsoleColor.Magenta);
                        PrintObject(56, 20, "GAME OVER!!!", ConsoleColor.Yellow);
                        PrintObject(6, 35, "press [ENTER]  to play again", ConsoleColor.Green);
                        PrintObject(6, 36, "press [ESCAPE] to exit", ConsoleColor.Green);

                        listOfObjects.Clear();
                        for (int i = 0; i < 7; i++)
                        {
                            gem[i].collected = false;
                        }
                        gameSpeed.delay = 250;
                        dwarf = new Object();
                        dwarf.x = playfieldWidth / 2;
                        dwarf.y = Console.WindowHeight - 1;
                        dwarf.color = ConsoleColor.DarkCyan;
                        dwarf.symbol = ((char)2).ToString();
                        dwarf.dwarfLives = 5;

                        info = Console.ReadKey();
                        if (info.Key == ConsoleKey.Escape)
                        {
                            return;
                        }
                        else
                        {
                            info = Console.ReadKey();
                            if (info.Key == ConsoleKey.Enter)
                            {
                                Main();
                            }
                        }
                    }
                    //result - failure
                    //DWARF has no more lifes and 7 gems are not collected

                    else if (dwarf.dwarfLives == 0 && (gem[0].collected == false || gem[1].collected == false || gem[4].collected == false
                                                || gem[5].collected == false || gem[6].collected == false))
                    {
                        for (int i = 200; i <= 2800; i += 800)
                        {
                            Console.Beep(i, 100);
                            Console.Beep(3400, 300);
                            Console.Beep(1000, 1000);
                        }

                        Console.Clear();

                        PrintObject(19, 4, ((char)2).ToString(), ConsoleColor.White);
                        PrintObject(17, 6, "O,NO!", ConsoleColor.Red);
                        PrintObject(12, 8, "YOU FAILED!", ConsoleColor.Red);
                        PrintObject(15, 18, "GAME OVER!!!", ConsoleColor.Yellow);
                        PrintObject(8, 22, "press [ENTER]  to play again", ConsoleColor.Green);
                        PrintObject(8, 24, "press [ESCAPE] to exit", ConsoleColor.Green);

                        listOfObjects.Clear();
                        for (int i = 0; i < 7; i++)
                        {
                            gem[i].collected = false;
                        }

                        gameSpeed.delay = 250;
                        dwarf = new Object();
                        dwarf.x = playfieldWidth / 2;
                        dwarf.y = Console.WindowHeight - 1;
                        dwarf.color = ConsoleColor.DarkCyan;
                        dwarf.symbol = ((char)2).ToString();
                        dwarf.dwarfLives = 5;

                        info = Console.ReadKey();
                        if (info.Key == ConsoleKey.Escape)
                        {
                            return;
                        }
                        else
                        {
                            info = Console.ReadKey();
                            if (info.Key == ConsoleKey.Enter)
                            {
                                Main();
                            }
                        }
                    }

                    //playng
                    else
                    {
                        Console.Clear();
                        PrintObject(dwarf.x, dwarf.y, dwarf.symbol, dwarf.color);
                        //rocks:
                        foreach (Object rocks in listOfObjects)
                        {
                            PrintObject(rocks.x, rocks.y, rocks.symbol, rocks.color);
                        }

                        //Rock is created and addes every time the program calls the while cicle)

                        // random generator - creates random possitions for the good rock (bonuses- in red)
                        int bonusChance = randomGenerator.Next(0, 100);

                        Object rock = new Object();
                        rock.x = randomGenerator.Next(0, playfieldWidth);  //will return RANDOM values 0 to playfieldWidth
                        rock.y = 0;                                         //object will apears always on the top line
                        //of console y = 0 is on the first Consol- row
                        //BONUSIES

                        if (bonusChance < 4) // chance 5%, when numbers 0,1,2,3,4,5 are randomly generated
                        {
                            // new live
                            rock.symbol = ((char)3).ToString();
                            rock.color = ConsoleColor.Red;
                        }
                        else if (bonusChance >= 4 && bonusChance < 8)
                        {
                            // rock speed reduction
                            rock.symbol = ((char)31).ToString();
                            rock.color = ConsoleColor.Red;
                        }

                        //gems

                        else if (bonusChance >= 10 && bonusChance < 12)
                        {
                            // gem power
                            rock.symbol = ((char)5).ToString();
                            rock.color = ConsoleColor.DarkRed;
                        }
                        else if (bonusChance >= 20 && bonusChance < 22)
                        {
                            // gem  smart mind
                            rock.symbol = ((char)6).ToString();
                            rock.color = ConsoleColor.Red;
                        }
                        else if (bonusChance >= 30 && bonusChance < 32)
                        {
                            // gem  let's sing 
                            rock.symbol = ((char)14).ToString();
                            rock.color = ConsoleColor.DarkRed;
                        }
                        else if (bonusChance >= 40 && bonusChance < 42)
                        {
                            // gem summer time
                            rock.symbol = ((char)15).ToString();
                            rock.color = ConsoleColor.Red;
                        }
                        else if (bonusChance >= 50 && bonusChance < 52)
                        {
                            // gem C#
                            rock.symbol = "C#";
                            rock.color = ConsoleColor.DarkRed;
                        }
                        else if (bonusChance >= 60 && bonusChance < 62)
                        {
                            // gem EDMOS award
                            rock.symbol = "EDMOS";
                            rock.color = ConsoleColor.DarkRed;
                        }

                        else if (bonusChance >= 98 && bonusChance < 100)
                        {
                            // gem comunication
                            rock.symbol = ((char)64).ToString();
                            rock.color = ConsoleColor.Red;
                        }

                        // bad rocks
                        else
                        {
                            rock.symbol = ((char)4).ToString();
                            rock.color = ConsoleColor.Green;
                        }
                        //Add to the list of object - rocks -diferent colors, whitout red

                        listOfObjects.Add(rock);

                        while (Console.KeyAvailable) // key pressed
                        {

                            //first read, then clear the buffer from old key
                            ConsoleKeyInfo pressedKey = Console.ReadKey(true);

                            //moving the DWARF
                            if ((pressedKey.Key == ConsoleKey.LeftArrow) && ((dwarf.x - 1) >= 0))
                            {
                                dwarf.x = dwarf.x - 1;
                            }
                            else if ((pressedKey.Key == ConsoleKey.RightArrow) && ((dwarf.x + 1) <= playfieldWidth - 1))
                            {
                                dwarf.x = dwarf.x + 1;
                            }
                        }


                        // falling rocks
                        //we create a new list of the same objects, but already in their new possitions,
                        //one position down from the old one or x is the same, y= y-1

                        List<Object> objectsInNewPositions = new List<Object>();

                        for (int i = 0; i < listOfObjects.Count; i++)
                        {

                            Object objectInOldPosition = listOfObjects[i];
                            Object objectInNewPosition = new Object();
                            objectInNewPosition.x = objectInOldPosition.x;
                            objectInNewPosition.y = objectInOldPosition.y + 1;
                            objectInNewPosition.color = objectInOldPosition.color;
                            objectInNewPosition.symbol = objectInOldPosition.symbol;

                            // if rock coordinates are the same as dwarf coordinates - the rock is hitting the dwarf !


                            //If bad rocks hit the DWARF:

                            if (objectInNewPosition.x == dwarf.x && objectInNewPosition.y == dwarf.y
                                             && objectInNewPosition.symbol == ((char)4).ToString())
                            {
                                //when bad rock hit the DWARF:
                                // 1. sign of crush "red X" appears
                                PrintObject(dwarf.x, dwarf.y, ('X').ToString(), ConsoleColor.DarkRed);

                                // 2. sound is sounding
                                Console.Beep(500, 1000);

                                // 3. Clean playfield from rocks 
                                listOfObjects.Clear();

                                // 4. The DWARF losses one life
                                dwarf.dwarfLives--;

                                // 5. The speed of the rocks increases
                                gameSpeed.delay -= 50;
                                if (gameSpeed.delay < 50)
                                {
                                    gameSpeed.delay = 50;
                                }
                            }

                            // When the DWARF gets bonus

                            else if (objectInNewPosition.x == dwarf.x && objectInNewPosition.y == dwarf.y
                                               && objectInNewPosition.symbol == ((char)3).ToString())
                            {
                                //Life - heart
                                PrintObject(dwarf.x, dwarf.y, "X", ConsoleColor.Yellow);
                                Console.Beep(1500, 1000);
                                dwarf.dwarfLives++;
                                if (dwarf.dwarfLives > 5)
                                {
                                    dwarf.dwarfLives = 5;
                                }
                                listOfObjects.Clear();

                            }
                            else if (objectInNewPosition.x == dwarf.x && objectInNewPosition.y == dwarf.y
                                     && objectInNewPosition.symbol == ((char)31).ToString())
                            {
                                //Reduction rocks speed
                                PrintObject(rock.x, rock.y, "X", ConsoleColor.Yellow);
                                Console.Beep(1500, 1000);
                                gameSpeed.delay += 50;
                                // delay upper limit
                                if (gameSpeed.delay > 250)
                                {
                                    gameSpeed.delay = 250;
                                }
                                listOfObjects.Clear();
                            }

                            //Gems

                            else if (objectInNewPosition.x == dwarf.x && objectInNewPosition.y == dwarf.y
                                    && objectInNewPosition.symbol == ((char)5).ToString())
                            {
                                //gem 0 - POWER
                                PrintObject(dwarf.x, dwarf.y, "X", ConsoleColor.Yellow);
                                Console.Beep(1500, 1000);
                                gem[0].symbol = ((char)5).ToString();
                                gem[0].collected = true;
                                listOfObjects.Clear();
                            }
                            else if (objectInNewPosition.x == dwarf.x && objectInNewPosition.y == dwarf.y
                                     && objectInNewPosition.symbol == ((char)6).ToString())
                            {
                                //gem 1 - NEW IDEA
                                PrintObject(dwarf.x, dwarf.y, "X", ConsoleColor.Yellow);
                                Console.Beep(1500, 1000);
                                gem[1].symbol = ((char)6).ToString();
                                gem[1].collected = true;
                                listOfObjects.Clear();
                            }
                            else if (objectInNewPosition.x == dwarf.x && objectInNewPosition.y == dwarf.y
                                     && objectInNewPosition.symbol == ((char)14).ToString())
                            {
                                //gem 2 - LET'S SING!
                                PrintObject(dwarf.x, dwarf.y, "X", ConsoleColor.Yellow);
                                for (i = 200; i <= 3000; i += 400)
                                {
                                    Console.Beep(i, 200);
                                }
                                Console.Beep(3400, 600);
                                Console.Beep(1000, 1000);
                                gem[2].symbol = ((char)14).ToString();
                                gem[2].collected = true;
                                listOfObjects.Clear();
                            }
                            else if (objectInNewPosition.x == dwarf.x && objectInNewPosition.y == dwarf.y
                                     && objectInNewPosition.symbol == ((char)15).ToString())
                            {
                                //gem 3 - SUMMER TIME 
                                PrintObject(dwarf.x, dwarf.y, "X", ConsoleColor.Yellow);
                                Console.Beep(1500, 1000);
                                gem[3].symbol = ((char)15).ToString();
                                gem[3].collected = true;
                                listOfObjects.Clear();
                            }
                            else if (objectInNewPosition.x == dwarf.x && objectInNewPosition.y == dwarf.y
                                && objectInNewPosition.symbol == "C#")
                            {
                                //gem 4 - LOVE C#
                                PrintObject(dwarf.x, dwarf.y, "X", ConsoleColor.Yellow);
                                Console.Beep(1500, 1000);
                                gem[4].symbol = "C#";
                                gem[4].collected = true;
                                listOfObjects.Clear();
                            }
                            else if (objectInNewPosition.x == dwarf.x && objectInNewPosition.y == dwarf.y
                                                   && objectInNewPosition.symbol == "EDMOS")
                            {
                                //gem 5  EDMOS award
                                PrintObject(dwarf.x, dwarf.y, "X", ConsoleColor.Yellow);
                                Console.Beep(1500, 1000);
                                gem[5].symbol = "EDMOS";
                                gem[5].collected = true;
                                listOfObjects.Clear();
                            }
                            else if (objectInNewPosition.x == dwarf.x && objectInNewPosition.y == dwarf.y
                                      && objectInNewPosition.symbol == ((char)64).ToString())
                            {
                                //gem 6 - COMUNICATION
                                PrintObject(dwarf.x, dwarf.y, "X", ConsoleColor.Yellow);
                                Console.Beep(1500, 1000);
                                gem[6].symbol = ((char)64).ToString();
                                gem[6].collected = true;
                                listOfObjects.Clear();
                            }


                            //New positions, filling the list of rocks

                            if (objectInNewPosition.y <= Console.WindowHeight - 1)
                            {
                                objectsInNewPositions.Add(objectInNewPosition);
                            }
                        }

                        //First must delete the rocks from old possition (X=x, Y=y )
                        //Then draw them on the new possitions (X=x , Y=y+1)
                        //Finaly must replace old list of rocks whit new one

                        listOfObjects = objectsInNewPositions;


                        //Some info 
                        PrintObject(50, 1, "LET'S  START!", ConsoleColor.Yellow);
                        PrintObject(40, 3, "GET BONUS! BE AWARE OF FALLING ROCKS!", ConsoleColor.Yellow);

                        //Printing lifes- THE HEARTS
                        PrintObject(100, 10, "DWARF'S LIVES ", ConsoleColor.Cyan);
                        int hearts = dwarf.dwarfLives;
                        int j = 1;
                        while (hearts > 0)
                        {
                            int num = 100 + 2 * j;
                            PrintObject(num, 12, " " + (char)3 + " ", ConsoleColor.Red);
                            hearts--;
                            j++;
                        }

                        //Printing speed - down arrows
                        PrintObject(100, 14, "ROCKS SPEED", ConsoleColor.Cyan);
                        switch (gameSpeed.delay)
                        {
                            case 50:
                                string str = new string((char)31, 5);
                                PrintObject(102, 16, str, ConsoleColor.Red);
                                break;
                            case 100:
                                str = new string((char)31, 4);
                                PrintObject(103, 16, str, ConsoleColor.Red);
                                break;

                            case 150:
                                str = new string((char)31, 3);
                                PrintObject(104, 16, str, ConsoleColor.Red);
                                break;

                            case 200:
                                str = new string((char)31, 2);
                                PrintObject(105, 16, str, ConsoleColor.Red);
                                break;
                            case 250:
                                str = new string((char)31, 1);
                                PrintObject(106, 16, str, ConsoleColor.Red);
                                break;
                        }

                        // Printing DWARF'S gems

                        PrintObject(100, 18, "DWARF'S GEMS", ConsoleColor.Cyan);

                        if (gem[0].collected)
                        {
                            PrintObject(100, 20, ((char)5).ToString(), ConsoleColor.DarkRed);
                        }
                        if (gem[1].collected)
                        {
                            PrintObject(105, 20, ((char)6).ToString(), ConsoleColor.Red);
                        }
                        if (gem[2].collected)
                        {
                            PrintObject(110, 20, ((char)14).ToString(), ConsoleColor.DarkRed);
                        }
                        if (gem[3].collected)
                        {
                            PrintObject(115, 20, ((char)15).ToString(), ConsoleColor.Red);
                        }
                        if (gem[4].collected)
                        {
                            PrintObject(100, 21, "C#", ConsoleColor.DarkRed);
                        }
                        if (gem[5].collected)
                        {
                            PrintObject(107, 21, "EDMOS", ConsoleColor.DarkRed);
                        }
                        if (gem[6].collected)
                        {
                            PrintObject(115, 21, ((char)64).ToString(), ConsoleColor.Red);
                        }

                        //Slowing down the speed
                        System.Threading.Thread.Sleep(gameSpeed.delay);
                    }
                }
            }
        }
    }
}