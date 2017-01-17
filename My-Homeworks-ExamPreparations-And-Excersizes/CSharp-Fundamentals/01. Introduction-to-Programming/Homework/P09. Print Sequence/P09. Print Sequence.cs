using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrintSequence
{
    static void Main(string[] args)
    {
        for (int i = 2; i<=11;i++)
        {
            int res = i;
            if (i % 2 == 1)
            {
                res = i * (-1);
            }
            Console.WriteLine("{0}", res);
        }
    }
}

