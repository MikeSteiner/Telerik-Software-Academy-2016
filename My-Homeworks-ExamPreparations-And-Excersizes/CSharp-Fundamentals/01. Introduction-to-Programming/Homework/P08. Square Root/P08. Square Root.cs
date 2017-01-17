using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SquareRoot
{
    static void Main(string[] args)
    {
        int number = 12345;
        if (number > 0)
        {
            double numberSqrt = Math.Sqrt(Convert.ToDouble(number));
            Console.WriteLine(numberSqrt);
        }
        else
        {
            Console.WriteLine("Please, enter a positeive value!");
        }
    }
}

