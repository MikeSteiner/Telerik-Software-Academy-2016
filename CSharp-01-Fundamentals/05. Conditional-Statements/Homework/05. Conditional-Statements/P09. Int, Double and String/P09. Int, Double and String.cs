using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************************************************************************
    Int, Double, String

    Description

    Write a program that, depending on the first line of the input, reads an int, double or string variable.

    If the variable is int or double, the program increases it by one.
    If the variable is a string, the program appends * at the end.
    Print the result at the console. Use switch statement.
    Input

    On the first line you will receive the type of input as string in the following form:
    integer for int
    real for double
    text for string
    On the second line you will be given the value of the variable.
    Output

    Write a single line on the console - the value transformed according to the rules from the description.
    Print all double variables with exactly 2-digits precision after the floating point. Example: 0.99
    Constraints

    The input will always be valid and in the described format.
    All input numbers will be between -1000 and 1000.
    Time limit: 0.1s
    Memory limit: 16MB
    Sample tests

Input	Output
integer
2	3
real
-2,5	-1,50
text
gosho	gosho*
     
********************************************************************************/

namespace P09.Int__Double_and_String
{
    class IntDoublAndString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            if (input.Equals("integer"))
            {
                long value = long.Parse(Console.ReadLine());
                Console.WriteLine(++value);

            } else if (input.Equals("real"))
            {
                string inStr = Console.ReadLine();
                double value = double.Parse(inStr);
                Console.WriteLine("{0:#0.00}",++value);
            }
            else if (input.Equals("text"))
            {
                string value = Console.ReadLine() + "*";
                Console.WriteLine(value);
            }
        }
    }
}
 