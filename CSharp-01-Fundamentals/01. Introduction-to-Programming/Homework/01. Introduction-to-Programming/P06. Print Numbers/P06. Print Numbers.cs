using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrintNumbers
{
    static void Main(string[] args)
    {
        int startNum = 1;
        for(int i = 0; i<=2; i++)
        {
            /*
            string s = i.ToString();
            string s = Convert.ToString(i);
            string s = string.Format("{0}", i);
            string s = "" + i;
            string s = string.Empty + i;
            string s = new StringBuilder().Append(i).ToString();
            */
            String prefixNum = "";
            if (Math.Pow(10d, (double)i) != 1)
            {
                //String prefixNum = Convert.ToString(10 * i);
                prefixNum = Math.Pow(10d, (double)i).ToString();
            }
           
            
            Console.WriteLine("{0}", prefixNum + startNum.ToString());
        }
    }
}

