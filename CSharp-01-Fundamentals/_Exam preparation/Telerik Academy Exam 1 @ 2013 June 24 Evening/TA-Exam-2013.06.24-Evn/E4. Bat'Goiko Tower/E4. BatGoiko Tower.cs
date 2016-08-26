/*
Problem 4 – Bat’Goiko Tower
Bat’Goiko is a famous Bulgarian builder. He spent most of his life building highways in his country. He was so good at his job that at some point there was no more place to build new highways. Bat’Goiko was very disappointed that he had no more work to do and decided to move to France to find more land for his future projects. Just hours after he landed in Paris, he came up with the bright idea to start building Eifel Towers in order to be more efficient with the space. He took the first plane back to Bulgaria and started building towers. 
After few vain attempts he found out some dependencies in the tower’s width and height. The first one being that, the tower should be at least two times wider than it is tall. And the other one was that the tower should have some crossbeams.  He started placing crossbeams from the top and he also decided that it’s a good idea to put less crossbeams the lower he went in the tower. He put the first one at the (top – 1), the second at (top – 3), the third at (top – 6) and so on till he got a stable tower.
Your task is to help him improve his work by drawing a realistic model of “Bat’Goiko Tower” by given height (H). 
Input
The input data should be read from the console.
You have an integer number H height of the tower.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console.
Use the “\”, “/”, “-” (dash) characters for the lines and “.” (dot) for the rest.
Constraints
•	H will always be a positive number between 2 and 39 inclusive.
•	Allowed working time for your program: 0.1 seconds.
•	Allowed memory: 16 MB.

Example input	Example output
11	
........../\..........
........./--\.........
......../....\........
......./------\.......
....../........\......
...../..........\.....
..../------------\....
.../..............\...
../................\..
./..................\.
/--------------------\

Examples
Example
input	Example
output
5	
..../\....
.../--\...
../....\..
./------\.
/........\



*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4.Bat_Goiko_Tower
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int sideDots = N - 1;

            //Top line    
            //........../\..........
            if (sideDots > 0)
            {
                Console.Write(new string('.', N - 1));
            }
            Console.Write(new string('/', 1));
            Console.Write(new string('\\', 1));
            if (sideDots > 0)
            {
                Console.Write(new string('.', N - 1));
            }
            Console.WriteLine();
            if (sideDots<=0)
            {
                return;
            }
            sideDots--;

            int otherColumnsCouter = 1;
            bool printMinusColumn = true;
            //bool printOtherColumn = false;
            for (int allColumns = 1; allColumns < N; allColumns++)
            {
                if (printMinusColumn)
                {
                    //........./--\.........
                    if (sideDots > 0)
                    {
                        Console.Write(new string('.', sideDots));
                    }
                    Console.Write(new string('/', 1));
                    Console.Write(new string('-', 2 * (N - 1 - sideDots)));
                    Console.Write(new string('\\', 1));
                    if (sideDots > 0)
                    {
                        Console.Write(new string('.', sideDots));
                    }
                    Console.WriteLine();
                    if (sideDots <= 0)
                    {
                        return;
                    }

                    sideDots--;
                    printMinusColumn = false;
                }
                else
                {
                    for (int i = 1; i <= otherColumnsCouter; i++)
                    {
                        //......../....\........
                        if (sideDots > 0)
                        {
                            Console.Write(new string('.', sideDots));
                        }                        
                        Console.Write(new string('/', 1));
                        Console.Write(new string('.', 2 * (N - 1 - sideDots)));
                        Console.Write(new string('\\', 1));
                        if (sideDots > 0)
                        {
                            Console.Write(new string('.', sideDots));
                        }
                        Console.WriteLine();
                        if (sideDots <= 0)
                        {
                            return;
                        }

                        sideDots--;
                    }
                    printMinusColumn = true;
                    otherColumnsCouter++;
                }
                //........./--\.........
                //Console.Write(new string('.', sideDots));
                //Console.Write(new string('/', 1));
                //Console.Write(new string('-', 2 * allColumns));
                //Console.Write(new string('\\', 1));
                //Console.Write(new string('.', sideDots));

                //sideDots--;


            }


        }
    }
}
