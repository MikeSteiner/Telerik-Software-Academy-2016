/*

Telerik Academy Season 2016-2017 / C# Fundamentals Exam - 25 April 2016 

Task 4: Batman

Description

We all know who Batman is, don't we? Help the people in trouble to call him for help. All you have to do is print the batman sign on the console and then project it in the sky. Just kidding. Print it only on the console. If you project it in the sky you will automatically receive the Ninja Certificate :)

Input

All input data is read from the standard input (the console)
•On the first line you will receive an integer  S  ◦The size of Batman's sign to print

•On the second line you will receive the character  C  with which you will have to print the sign

Output

The output data is printed on the standard output (the console)
•You have to print the sign on the console

Constraints
•  S  will always be an odd integer between  5  and  51  inclusive
•  C  will be a character from the ASCII table
•Allowed memory: 16 MiB 
•Allowed working time for your program: 0.10 seconds 
• The input data will always be correct and there is no need to check it explicitly 




Sample Tests

Sample Input 1
5
#


Sample Output 1
#####     #####
 #### # # ####
  ###########
      ###
       #        5+(N-5)/2


Sample Input 2
7
$


Sample Output 2
$$$$$$$       $$$$$$$
 $$$$$$       $$$$$$
  $$$$$  $ $  $$$$$
   $$$$$$$$$$$$$$$
   $$$$$$$$$$$$$$$
        $$$$$
         $$$
          $


Sample Input 3
9
%


Sample Output 3
%%%%%%%%%         %%%%%%%%%
 %%%%%%%%         %%%%%%%%
  %%%%%%%         %%%%%%%
   %%%%%%   % %   %%%%%%
    %%%%%%%%%%%%%%%%%%%
    %%%%%%%%%%%%%%%%%%%
    %%%%%%%%%%%%%%%%%%%
          %%%%%%%
           %%%%%
            %%%
             %

 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4.Batman_Description
{
    class Batman_Description
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            char S = char.Parse(Console.ReadLine());


            //Top line
            //7
            //$$$$$$$       $$$$$$$
            Console.Write(new string(S, N));
            Console.Write(new string(' ', N));
            Console.Write(new string(S, N));
            Console.WriteLine();

            //Middle top repeat part
            // $$$$$$       $$$$$$
            int sideSpaces = 1;
            int repeat = (N - 5) / 2;
            //int repeat = (int)Math.Pow(2, (N - 5 - 2));
            //repeat = 1;
            //switch (N)
            //{
            //    case 5:
            //        repeat = 0;
            //        break;
            //    case 7:
            //        repeat = 1;
            //        break;
            //    case 9:
            //        repeat = 2;
            //        break;
            //    case 11:
            //        repeat = 4;
            //        break;
            //    case 13:
            //        repeat = 8;
            //        break;
            //    case 15:
            //        repeat = 16;
            //        break;
            //    case 17:
            //        repeat = 32;
            //        break;
            //}
            //for (int i = 1; i <= (N - 5) / 2; i++)
            for (int i = 1; i <= repeat; i++)
            {
                Console.Write(new string(' ', sideSpaces));
                Console.Write(new string(S, N - sideSpaces));
                Console.Write(new string(' ', N));
                Console.Write(new string(S, N - sideSpaces));
                Console.Write(new string(' ', sideSpaces));
                Console.WriteLine();

                sideSpaces++;
                if(N - sideSpaces == 1)
                {
                    sideSpaces++;
                    break;
                }
            }

            //Middle line
            //  $$$$$  $ $  $$$$$
            Console.Write(new string(' ', sideSpaces));
            Console.Write(new string(S, N - sideSpaces));
            Console.Write(new string(' ', (N - 3) / 2));
            Console.Write(new string(S, 1));
            if(N % 2 == 1)
            {
                Console.Write(new string(' ', 1));
            }
            else
            {
                Console.Write(new string(' ', 2));
            }
            Console.Write(new string(S, 1));
            Console.Write(new string(' ', (N - 3) / 2));
            Console.Write(new string(S, N - sideSpaces));
            Console.Write(new string(' ', sideSpaces));
            Console.WriteLine();



            //Middle bottom repeat part
            //   %%%%%%%%%%%%%%%%%%%
            //   %%%%%%%%%%%%%%%%%%%
            //   %%%%%%%%%%%%%%%%%%%
            //sideSpaces = (N - 1) / 2;
            //for (int i = 0; i < (N - 1) / 2 -1; i++)   
            sideSpaces++;
            
            for (int i = 0; i < repeat + 1; i++)
            {

                Console.Write(new string(' ', sideSpaces));
                Console.Write(new string(S, N * 3 - sideSpaces - sideSpaces));
                Console.Write(new string(' ', sideSpaces));
                Console.WriteLine();               

            }



            //Bottom part
            //7
            //$$$$$
            // $$$
            //  $
            int middleSyms = (N - 2);
            //for (int i = 0; i < (N -1) / 2; i++)
            for (int i = 0; i < repeat+2; i++)
            {
                int sides = (N * 3 - middleSyms) / 2;
                Console.Write(new string(' ', sides));
                Console.Write(new string(S, middleSyms));
                Console.Write(new string(' ', sides));
                Console.WriteLine();
                middleSyms = middleSyms -2;
                if (middleSyms<=0)
                {
                    break;
                }

            }
        }
    }
}
