using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*

*/

class FourDigits
{
    static void Main(string[] args)
    {
       
        string nStr = Console.ReadLine();
        StringBuilder nSb = new StringBuilder(nStr);
        int a;
        int b;
        int c;
        int d;

        a = Convert.ToInt32(char.GetNumericValue(nSb[0]));
        b = Convert.ToInt32(char.GetNumericValue(nSb[1]));
        c = Convert.ToInt32(char.GetNumericValue(nSb[2]));
        d = Convert.ToInt32(char.GetNumericValue(nSb[3]));

        StringBuilder tempSb = new StringBuilder();
        //string outFormat = "{1}{2}{3}{4}";

        //Sum
        int sum = a + b + c + d;
        Console.WriteLine("{0}", sum);
        
        //Reverse
        char[] chArr = nStr.ToCharArray();
        Array.Reverse(chArr);
        tempSb = new StringBuilder(new String(chArr));
        Console.WriteLine("{0}", tempSb);

        //Exchange first and last digit
        tempSb.Clear();
        tempSb.Append(d.ToString()).Append(a.ToString()).Append(b.ToString()).Append(c.ToString());
        Console.WriteLine("{0}", tempSb);

        //Exchange middle digits
        tempSb.Clear();
        tempSb.Append(a.ToString()).Append(c.ToString()).Append(b.ToString()).Append(d.ToString());
        Console.WriteLine("{0}", tempSb);

    }
}

