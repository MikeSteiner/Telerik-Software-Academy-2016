using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Description

Find online more information about ASCII (American Standard Code for Information Interchange) and write a program 
that prints the visible characters of the ASCII table on the console (characters from 33 to 126 including).
 
*/

class PrintTheASCIITable
{
    static void Main(string[] args)
    {
        for (int i = 33; i <= 126; i++)
        {
            //Console.WriteLine((char)i);
            Console.Write(Convert.ToChar(i));
        }
    }
}

