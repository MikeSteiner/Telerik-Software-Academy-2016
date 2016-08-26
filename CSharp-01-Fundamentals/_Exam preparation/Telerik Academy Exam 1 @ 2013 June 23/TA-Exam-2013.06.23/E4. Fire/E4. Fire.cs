/*
    Problem – Fire in the Matrix
    The summer is coming. Birds are singing, trees are green, girls wear short skirts… Yeah, right, in your dreams! Even though it is June, the weather is awful. To warm ourselves, we need fire. Lots of fire! Lots of lots of FIRE!!!
    And since we are living in the Matrix, the super-duper-human rescuer Neo will need to write a program about creating big torches of fire. Unfortunately Neo is just a simple Kung-Fu master, who likes to fly in the sky. You will have to help him otherwise people will freeze!
    Your task is to print on the console a torch of fire with width N following the examples below.
    Input 
    The input data is being read from the console.
    On the only line will hold an integer number N, indicating the width of the fire in the torch.
    The input data will always be valid and in the format described. There is no need to check it explicitly.
    Output
    The output data must be printed on the console.
    You should print the fire on the console. Use the symbol “#” (number sign) to mark the fire, “-“ (dash) to show the top of the torch and “/” (slash) or “\” (backslash) to illustrate the torch.
    Constraints
    •	N will be a positive integer in the range [4…76] and will always be divisible by 4.
    •	Allowed working time for your program: 0.25 second.
    •	Allowed memory: 16 MB.

Examples
Input	Output		Input	Output
8	
.##.
#..#
#..#
.##.
----
\\//
.\/.

8	
...##...
..#..#..
.#....#.
#......#
#......#
.#....#.
--------
\\\\////
.\\\///.
..\\//..
...\/...		

12	
.....##.....
....#..#....
...#....#...
..#......#..
.#........#.
#..........#
#..........#
.#........#.
..#......#..
------------
\\\\\\//////
.\\\\\/////.
..\\\\////..
...\\\///...
....\\//....
.....\/.....




 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4.Fire
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            //Top lines
            Console.WriteLine("{0}{1}{0}",
                new string('.', N / 2 - 1),
                new string('#', 2)
            );
            int sideDots = 1;
            int middleDots = 1;
            int loopIncStar = 1;

            if (N != 4)
            {
                //Increasing #
                //12
                //....#..#....
                //...#....#...
                //..#......#..
                //.#........#.            
                sideDots = N / 2 - 2;
                middleDots = 2;
                loopIncStar = 0;
                for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}",
                        new string('.', sideDots),
                        new string('#', 1),
                        new string('.', middleDots)
                    );

                    loopIncStar++;
                    if (sideDots == 1)
                    {
                        break;
                    }
                    sideDots = sideDots - 1;
                    middleDots = middleDots + 2;

                }
            }
            

            //Middle #
            //#..........#
            //#..........#
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("{0}{1}{0}",
                    new string('#', 1),
                    new string('.', N - 2)
                );
            }

            if (N != 4)
            {
                //Decreasing #
                //.#........#.
                //..#......#..
                for (int i = 1; i <= loopIncStar / 2; i++)
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}",
                        new string('.', sideDots),
                        new string('#', 1),
                        new string('.', middleDots)
                    );
                    sideDots = sideDots + 1;
                    middleDots = middleDots - 2;
                }
            }            

            //Minus line -
            //------------
            Console.WriteLine("{0}",
                    new string('-', N)
            );

            //Middle \/
            //\\\\\\//////
            Console.WriteLine("{0}{1}",
                    new string('\\', N/2),
                    new string('/', N/2)
                );

            //Decreasing \/
            //.\\\\\/////.
            //..\\\\////..
            //...\\\///...
            //....\\//....
            //.....\/.....
            sideDots = 1;
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("{0}{1}{2}{0}",
                    new string('.', sideDots),
                    new string('\\', N / 2 - sideDots),
                    new string('/', N / 2 - sideDots)
                );

                if (sideDots == N / 2 - 1)
                {
                    break;
                }
                sideDots++;
            }
        }
    }
}
