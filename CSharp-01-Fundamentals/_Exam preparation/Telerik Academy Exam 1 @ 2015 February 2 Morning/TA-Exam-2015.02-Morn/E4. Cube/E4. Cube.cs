using System;
/*
    Problem 4 – Cube
    Ivcho is a big computer genius. One day he was bored from all the girls that wanted to be with him and instead decided to wright a computer game. Because he always likes to do things the hard way he decided to make a console game, but not any console game – a 3D one! Just for the fun of it. But because he isn’t very good with graphics he needs your help with the basic building blocks witch he can feed to his magic algorithm that produces HD 3D-reality in the console.
    Your task is to wright a program that supplies him with cubes (basic building blocks). He will give you a number N and you should print a cube with width = height = depth = N as shown in the examples. Mark the sides with “:” (colon).
    In addition you will have to fill in some of the sides of the cube:
    •	The top should be filled in with “/” (slash)
    •	The side should be filled in with “X” (capital letter X)
    Input
    The input data should be read from the console.
    On the first row you have an integer number N between 4 and 100 (inclusive) – the size of the cube.
    The input data will always be valid and in the format described. There is no need to check it explicitly.
    Output
    The output should be printed on the console.
    You should print the cube on the console. Each row can contain only the following characters: “ ” (space),”X” (letter X), “/” (slash) and “:” (colon). As shown in the example.
    Constraints
    •	The number N will be a positive integer number between 4 and 100, inclusive.
    •	Allowed working time for your program: 0.1 seconds.
    •	Allowed memory: 16 MB.
Examples:
Input example	Output example		Input example	Output example
5

	    :::::
   :///::
  :///:X:
 :///:XX:
:::::XXX:
:   :XX: 
:   :X:  
:   ::   
:::::		8	       ::::::::
      ://////::
     ://////:X:
    ://////:XX:
   ://////:XXX:
  ://////:XXXX:
 ://////:XXXXX:
::::::::XXXXXX:
:      :XXXXX: 
:      :XXXX:  
:      :XXX:   
:      :XX:    
:      :X:     
:      ::      
::::::::       



*/
namespace E4.Cube
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            //Top lines
            Console.WriteLine("{0}{1}",
                new string(' ', N-1),
                new string(':', N)
            );
            Console.WriteLine("{0}{1}{2}{3}",
                new string(' ', N - 2),
                new string(':', 1),
                new string('/', N-2),
                new string(':', 2)
            );
            //Top repeated lines
            int spaceLeft = N - 3;
            int xRight = 1;
            for (int i = 1; i <= N-3; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{3}{1}",
                    new string(' ', spaceLeft),
                    new string(':', 1),
                    new string('/', N - 2),
                    new string('X', xRight)
                );
                spaceLeft--;
                xRight++;
            }            
            //Middle line ***********************************
            Console.WriteLine("{0}{1}{2}",
                new string(':', N),
                new string('X', N-2),
                new string(':', 1)
            );
            //Bottom repeated lines
            int spaceRight = 1;
            xRight = N-3;
            for (int i = 1; i <= N - 3; i++)
            {
                Console.WriteLine("{0}{1}{0}{2}{0}{3}",
                    new string(':', 1),
                    new string(' ', N-2),
                    new string('X', xRight),
                    new string(' ', spaceRight)
                );
                spaceRight++;
                xRight--;
            }
            //Bottom lines
            Console.WriteLine("{0}{1}{2}{1}",
                new string(':', 1),
                new string(' ', N - 2),
                new string(':', 2)
            );
            Console.WriteLine("{0}{1}",
                new string(':', N),
                new string(' ', N - 1)
            );
        }
    }
}
