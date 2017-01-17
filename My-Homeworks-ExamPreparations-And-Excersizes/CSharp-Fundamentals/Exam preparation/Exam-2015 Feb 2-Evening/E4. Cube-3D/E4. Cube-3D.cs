/*
Problem 4 – Cube 3D
Ivcho is a big computer genius. One day he was bored from all the girls that wanted to be with him and instead decided to wright a computer game. Because he always likes to do things the hard way he decided to make a console game, but not any console game – a 3D one! Just for the fun of it. But because he isn’t very good with graphics he needs your help with the basic building blocks witch he can feed to his magic algorithm that produces HD 3D-reality in the console.
Your task is to wright a program that supplies him with cubes (basic building blocks). He will give you a number N and you should print a cube with width = height = depth = N as shown in the examples. Mark the sides with “:” (colon). In addition you will have to fill in some of the sides of the cube:
•	The side should be filled in with “|” (vertical line)
•	The bottom should be filled in with “-” (minus)
Input
The input data should be read from the console.
On the first row you have an integer number N between 4 and 100 (inclusive) – the size of the cube.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console.
You should print the cube on the console. Each row can contain only the following characters: “ ” (space),”|” (vertical line), “-” (minus) and “:” (colon). As shown in the example.
Constraints
•	The number N will be a positive integer number between 4 and 100, inclusive.
•	Allowed working time for your program: 0.1 seconds.
•	Allowed memory: 16 MB.
Examples:
Input example	Output example		Input example	Output example

    5
	:::::    
    :   ::   
    :   :|:  
    :   :||: 
    :::::|||:
     :---:||:
      :---:|:
       :---::
        :::::		
    
    6	
    ::::::     
    :    ::    
    :    :|:   
    :    :||:  
    :    :|||: 
    ::::::||||:
     :----:|||:
      :----:||:
       :----:|:
        :----::
         ::::::


*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4.Cube_3D
{
    class Cube3D
    {
        static void Main(string[] args)
        {


            int N = int.Parse(Console.ReadLine());
            char[,] cube = new char[2 * N - 1, 2 * N - 1];
            //cube[y, x]

            //Top frame
            for (int i = 0; i < N; i++)
            {
                //Horisontal lines
                //Console.SetCursorPosition(i, 0);                
                //Console.Write(':');
                cube[0,i] = ':';
                //Console.SetCursorPosition(i, N - 1);
                //Console.Write(':');
                cube[N - 1, i] = ':';

                //Vertical lines
                //Console.SetCursorPosition(0, i);
                //Console.Write(':');
                cube[i, 0] = ':';
                //Console.SetCursorPosition(N-1, i);
                //Console.Write(':');
                cube[i, N - 1] = ':';
            }

            //Middle part top line
            for (int i = 0; i < N; i++)
            {
                //Console.SetCursorPosition(N - 1 + i, i);
                //Console.Write(':');
                cube[i, N - 1 + i] = ':';
            }
            //Middle part midle line
            for (int i = 0; i < N; i++)
            {
                //Console.SetCursorPosition(N - 1 + i, N - 1 + i);
                //Console.Write(':');
                cube[N - 1 + i, N - 1 + i] = ':';
            }
            //Middle part bottom line
            for (int i = 0; i < N; i++)
            {
                //Console.SetCursorPosition(i, N - 1 + i);
                //Console.Write(':');
                cube[N - 1 + i, i] = ':';
            }

            //Bottomn frame
            for (int i = 0; i < N; i++)
            {
                //Vertical Line
                //Console.SetCursorPosition((2 * (N - 1)), (i + N - 1));
                //Console.Write(':');
                cube[i + N - 1, 2 * (N - 1)] = ':';
                //Horisontal line
                //Console.SetCursorPosition((i + (N - 1)), (2 * (N -1)));
                //Console.Write(':');
                cube[2 * (N - 1), i + (N - 1)] = ':';

            }



            //****************

            for (int i = 0; i < N - 2; i++)
            {
                //Right side full out
                for (int c = 2; c < N ; c++)
                {
                    //Console.SetCursorPosition(N + i, c + i);
                    //Console.WriteLine('|');
                    cube[c + i, N + i] = '|';
                }

                //Bottom side fill out
                for (int c = 2; c < N; c++)
                {
                    //Console.SetCursorPosition(c + i, N + i);
                    //Console.WriteLine('-');
                    cube[N + i, c + i] = '-';
                }
            }


            for (int x = 0; x < 2 * N - 1; x++)
            { 
                for (int y = 0; y < 2 * N - 1; y++)
                {
                    char symbol = cube[x, y];
                    if (symbol == 0)
                    {
                        symbol = ' ';
                    }
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }


            //****************************** SetCursorPositiont is not working for BgCoder
            //Top frame
            //for (int i = 0; i < N; i++)
            //{
            //    //Horisontal lines
            //    Console.SetCursorPosition(i, 0);
            //    Console.Write(':');
            //    Console.SetCursorPosition(i, N - 1);
            //    Console.Write(':');
            //    //Vertical lines
            //    Console.SetCursorPosition(0, i);
            //    Console.Write(':');
            //    Console.SetCursorPosition(N - 1, i);
            //    Console.Write(':');
            //}

            ////Middle part top line
            //for (int i = 0; i < N; i++)
            //{
            //    Console.SetCursorPosition(N - 1 + i, i);
            //    Console.Write(':');
            //}
            ////Middle part midle line
            //for (int i = 0; i < N; i++)
            //{
            //    Console.SetCursorPosition(N - 1 + i, N - 1 + i);
            //    Console.Write(':');
            //}
            ////Middle part bottom line
            //for (int i = 0; i < N; i++)
            //{
            //    Console.SetCursorPosition(i, N - 1 + i);
            //    Console.Write(':');
            //}
            ////Bottomn frame
            //for (int i = 0; i < N; i++)
            //{
            //    //Vertical Line
            //    Console.SetCursorPosition((2 * (N - 1)), (i + N - 1));
            //    Console.Write(':');
            //    //Horisontal line
            //    Console.SetCursorPosition((i + (N - 1)), (2 * (N - 1)));
            //    Console.Write(':');

            //}
            ////***************
            //for (int i = 0; i < N - 2; i++)
            //{
            //    //Right side full out
            //    for (int c = 2; c < N; c++)
            //    {
            //        Console.SetCursorPosition(N + i, c + i);
            //        Console.WriteLine('|');
            //    }
            //    //Bottom side fill out
            //    for (int c = 2; c < N; c++)
            //    {
            //        Console.SetCursorPosition(c + i, N + i);
            //        Console.WriteLine('-');
            //    }
            //}




        }
    }
}
