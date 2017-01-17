using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02.Random_numbers
{
    class RandomNumbers
    {
        static void Main(string[] args)
        {
            PrintRandomValues(10);
        }

        static void PrintRandomValues(int count)
        {
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(rand.Next(100, 200)); 
            }
        }

    }
}
