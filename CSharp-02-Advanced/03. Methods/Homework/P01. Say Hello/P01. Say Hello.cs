/*
 * Say Hello
Description

Write a method that asks the user for his name and prints Hello, <name>!. Write a program to test this method.

Input

On the first line you will receive a name
Output

Print Hello, <name>!
Constraints

Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input   Output
Peter   Hello, Peter!
Submission
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SayHello
{
    
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            SayHello(name);
        }

        static void SayHello(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }

}
