using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*

*/

class ThirdDigit
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int thirdDigitComparator = 7;

        //Reverce string
        char[] chArr = N.ToString().ToCharArray();
        Array.Reverse(chArr);
        string nStrRev = new String(chArr);

        //Take third digit
        char thirdChar;
        int thirdCharInt;

        if (nStrRev.Length >= 3)
        {
            thirdChar = nStrRev[2];
            thirdCharInt = Convert.ToInt32(char.GetNumericValue(nStrRev[2]));
        }
        else
        {
            thirdCharInt = 0;
        }        
    
        //real comparisment
        if (thirdCharInt == thirdDigitComparator)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false {0}\n\r", thirdCharInt);
        }
        //Console.Write("{0}\n\r", N);


    }
}

