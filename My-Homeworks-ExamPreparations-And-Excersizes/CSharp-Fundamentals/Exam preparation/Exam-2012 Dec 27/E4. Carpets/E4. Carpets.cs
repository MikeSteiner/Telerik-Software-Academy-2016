/*
Problem 4 – Carpets
Telerik Academy is considering opening a new office in Great Britain. Therefore the whole Trainers team is traveling to the United Kingdom for the important event. Of course all of them want to feel exactly like home in the new office, so they ordered some special carpets from Chiprovtsi. Those carpets consist of many embedded rhombs. Please help them and print some carpets in different sizes for the new Telerik Academy Head Quarters.
Input
The input data should be read from the console.
You have an integer number N (always even number) showing the width and the height of the most outer rhomb. The width and the height will always be equal.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console.
Use the “/” and “\” characters to print the rhomb sides and “.” (dot) for the rest. You should print exactly one space between each rhomb.
Constraints
•	N will always be a positive even number between 6 and 80 inclusive.
•	Allowed working time for your program: 0.1 seconds.
•	Allowed memory: 16 MB.

Examples
Example
input	Example
output

6	
../\..
./  \.
/ /\ \
\ \/ /
.\  /.
..\/..
Example input	Example output
12	
...../\.....
..../  \....
.../ /\ \...
../ /  \ \..
./ / /\ \ \.
/ / /  \ \ \
\ \ \  / / /
.\ \ \/ / /.
..\ \  / /..
...\ \/ /...
....\  /....
.....\/.....

 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4.Carpets
{
    class Carpets
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            //Top lines
            //12
            //...../\.....
            //..../  \....
            //.../ /\ \...
            //../ /  \ \..
            //./ / /\ \ \.
            /// / /  \ \ \

            int sideDots = N / 2 - 1;
            for (int line = 0; line < N /2 ; line++)
            {
                //Middle part left outer
                Console.Write(new string('.', sideDots));
                Console.Write(new string('/', 1));

                //Middle part left inner
                int mCounter = 1;
                int middlePart = (N / 2) - (sideDots + 1);
                while(middlePart > 0)
                {
                    bool isSpace = mCounter % 2 == 1;
                    if (isSpace)
                    {
                        Console.Write(new string(' ', 1));
                    }
                    else
                    {
                        Console.Write(new string('/', 1));
                    }

                    mCounter++;
                    middlePart--;
                }

                //Middle part right inner
                mCounter = 1;
                middlePart = (N / 2) - (sideDots + 1);
                while (middlePart > 0)
                {
                    bool isSpace = false;
                    if (line % 2 == 1)
                    {
                        isSpace = mCounter % 2 == 1;
                    }
                    else
                    {
                        isSpace = mCounter % 2 == 0;
                    }
                    
                    //bool isSpace = mCounter % 2 == 0;
                    if (isSpace)
                    {
                        Console.Write(new string(' ', 1));
                    }
                    else
                    {
                        Console.Write(new string('\\', 1));
                    }

                    mCounter++;
                    middlePart--;
                }

                //Middle part right outer
                Console.Write(new string('\\', 1));
                Console.Write(new string('.', sideDots));



                sideDots--;
                //New line
                Console.WriteLine();
            }

            //Bottom lines
            //12
            //\ \ \  / / /
            //.\ \ \/ / /.
            //..\ \  / /..
            //...\ \/ /...
            //....\  /....
            //.....\/.....
            //sideDots = N / 2 - 1;
            sideDots = 0;
            for (int line = N / 2; line > 0 ; line--)
            {
                //Middle part left outer
                Console.Write(new string('.', sideDots));
                Console.Write(new string('\\', 1));

                //Middle part left inner
                int mCounter = 1;
                int middlePart = (N / 2) - (sideDots + 1);
                while (middlePart > 0)
                {
                    bool isSpace = mCounter % 2 == 1;
                    if (isSpace)
                    {
                        Console.Write(new string(' ', 1));
                    }
                    else
                    {
                        Console.Write(new string('\\', 1));
                    }

                    mCounter++;
                    middlePart--;
                }

                //Middle part right inner
                mCounter = 1;
                middlePart = (N / 2) - (sideDots + 1);
                while (middlePart > 0)
                {
                    bool isSpace = false;
                    if (line % 2 == 0)
                    {
                        isSpace = mCounter % 2 == 1;
                    }
                    else
                    {
                        isSpace = mCounter % 2 == 0;
                    }

                    //bool isSpace = mCounter % 2 == 0;
                    if (isSpace)
                    {
                        Console.Write(new string(' ', 1));
                    }
                    else
                    {
                        Console.Write(new string('/', 1));
                    }

                    mCounter++;
                    middlePart--;
                }

                //Middle part right outer
                Console.Write(new string('/', 1));
                Console.Write(new string('.', sideDots));



                sideDots++;
                //New line
                Console.WriteLine();
            }

        }
    }
}
