using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2.Tribonacci_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());
            long L = long.Parse(Console.ReadLine());

            List<long> results = new List<long>();
            results.Add(a);            
            results.Add(b);
            results.Add(c);
            

            for (int line = 3; line <= L; line++)
            {
                for (int i = 1; i <= line; i++)
                {
                    long d = a + b + c;
                    results.Add(d);

                    a = b;
                    b = c;
                    c = d;
                }
                
            }

            //Console.WriteLine("{0}", string.Join(" ", results));
            //foreach (string item in results)
            //{
            //    Console.Write(item);
            //    if (!item.Equals("\n\r"))
            //    {
            //        Console.Write(" ");
            //    }                
            //}
            //Console.WriteLine();
             
            //Print out
            int j = 0;
            for (int line = 1; line <= L; line++)
            {                
                for (int i = 1; i <= line; i++)
                {
                    Console.Write("{0} ", results[j]);
                    j++; 
                }
                Console.WriteLine();

            }




        }
    }
}
