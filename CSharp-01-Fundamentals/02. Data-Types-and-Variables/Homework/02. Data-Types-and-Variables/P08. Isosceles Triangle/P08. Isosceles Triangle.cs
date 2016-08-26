using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Description

    Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:

       ©

      © ©

     ©   ©

    © © © ©
    Note: The © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console.

    Note: Under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.
 
*/

class IsoscelesTriangle
{
    static void Main(string[] args)
    {

        char spC = ' ';
        spC = (char)32;        
        char cR = '\u00A9';//'\u00AE' is R

        //Console encoding
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        //Top line
        Console.WriteLine("{0}{1}{0}",
                new string(' ', 3),
                new string(cR, 1)            
            );

        //Middle lines
        int outerSpace = 2;
        int innerSpace = 1;
        for(int i = 2; i >= 1; i--)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}",
                new string(' ', outerSpace),
                new string(cR, 1),
                new string(' ', ((innerSpace * 2) - 1))
            );
            outerSpace--;
            innerSpace++;
        }

        //Botomn line
        Console.WriteLine("{1}{0}{1}{0}{1}{0}{1}",
                new string(' ', 1),
                new string(cR, 1)                
            );

    }
}
