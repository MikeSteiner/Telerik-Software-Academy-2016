/*
Dumpty Humpty was climbing a tower.
Dumpty Humpty did not have enough power…
Eh, I can’t rhyme so I will give you the abridged version – Dumpty Humpty was a huge egg with hands and legs and a very annoying attitude towards life. One day when he was very bored he decided to climb Bat’Goiko’s tower along with his family. But it was very tall and it was very windy on the top – so the wind pushed Dumpty Humpty and every egg in his family, they all fell to the ground and all of them cracked right down the middle. Your task is to ignore the possibility of a delicious omelet and to help the egg family by sewing them together. 
You will be given a number N which is the size of the egg that you are currently trying to fix.
Each egg’s height is 2 times the input (2 * N), the width is 3 * N – 1 and the width of the drawing area is 3 * N + 1. The sizes of the top and the bottom of the egg are N – 1.
The cracks are in the middle of the egg. They must be fixed on 2 lines and with the ‘@’ and ‘.’ characters alternating. The first line must start with a ‘@’ and the second ‘.’.
Input
The input data should be read from the console.
You have an integer number N - the size of the egg.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console.
Use the “*” character for the outer shell, the “@” character for the cracks and “.” (dot) for the rest.
Constraints
•	N will always be a positive even number between 2 and 26 inclusive.
•	Allowed working time for your program: 0.1 seconds.
•	Allowed memory: 16 MB.

Example input	Example output
4	
.....***.....
...*.....*...
.*.........*.
.*@.@.@.@.@*.
.*.@.@.@.@.*.
.*.........*.
...*.....*...
.....***.....
Examples
Example
input	Example
output
2	
...*...
.*@.@*.
.*.@.*.
...*...

 

Example input	Example output
6	
.......*****.......
.....*.......*.....
...*...........*...
.*...............*.
.*...............*.
.*@.@.@.@.@.@.@.@*.
.*.@.@.@.@.@.@.@.*.
.*...............*.
.*...............*.
...*...........*...
.....*.......*.....
.......*****.......


 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4.Eggcelent
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            //Top line
            //.....***.....
            int middleStars = N / 2 - 1;
            int sideDots = (N * 3) / 2 - middleStars;
            Console.Write(new string('.', sideDots));
            Console.Write(new string('*', middleStars));
            Console.Write(new string('*', 1));
            Console.Write(new string('*', middleStars));
            Console.Write(new string('.', sideDots));
            Console.WriteLine();

            //Top decrease
            //4
            //...*.....*...
            //.*.........*.

            //6
            //.....*.......*.....
            //...*...........*...
            //.*...............*.
            //.*...............*.

            sideDots = N - 1;
            for (int i = 1; i <= N -2; i++)
            {
                Console.Write(new string('.', sideDots));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', N * 3 + 1 - sideDots * 2 - 2));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', sideDots));
                
                sideDots = sideDots - 2;
                if(sideDots <= 1)
                {
                    sideDots = 1;
                }
                Console.WriteLine();
            }


            //Middle lines
            //.*@.@.@.@.@*.
            //.*.@.@.@.@.*.
            Console.Write(new string('.', 1));
            Console.Write(new string('*', 1));
            for (int i = 1; i <= (N * 3 + 1) * 2 - 6; i++)
            {
                bool isOdd = i % 2 == 1;
                

                if (i == N * 3  -1 -1)
                {
                    Console.Write(new string('*', 1));
                    Console.Write(new string('.', 1));
                    Console.WriteLine();
                    Console.Write(new string('.', 1));
                    Console.Write(new string('*', 1));
                    i++;
                }
                else
                {
                    if (isOdd)
                    {
                        Console.Write(new string('@', 1));
                    }
                    else
                    {
                        Console.Write(new string('.', 1));
                    }
                }
            }
            Console.Write(new string('*', 1));
            Console.Write(new string('.', 1));
            Console.WriteLine();

            //Bottom decrease
            //4
            //...*.....*...
            //.*.........*.

            //6
            //.*...............*.
            //.*...............*.
            //...*...........*...
            //.....*.......*.....
            //sideDots = N - 1;
            for (int i = 1; i <= N - 2; i++)
            {
                

                sideDots = sideDots + 2;
                if (i <= (N - 2) / 2)
                {
                    sideDots = 1;
                }
                Console.Write(new string('.', sideDots));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', N * 3 + 1 - sideDots * 2 - 2));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', sideDots));

                Console.WriteLine();
            }


            //Bottom line
            //.....***.....
            middleStars = N / 2 - 1;
            sideDots = (N * 3) / 2 - middleStars;
            Console.Write(new string('.', sideDots));
            Console.Write(new string('*', middleStars));
            Console.Write(new string('*', 1));
            Console.Write(new string('*', middleStars));
            Console.Write(new string('.', sideDots));
            Console.WriteLine();
        }
    }
}
