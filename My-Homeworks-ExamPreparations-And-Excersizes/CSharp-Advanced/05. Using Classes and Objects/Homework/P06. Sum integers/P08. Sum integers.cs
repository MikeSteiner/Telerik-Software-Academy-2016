using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06.Sum_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inLine = Console.ReadLine();
            SumOfString sumStr = new SumOfString(inLine);
            Console.WriteLine(sumStr.CalcSumOfString());

        }
    }

    class SumOfString
    {       

        private string inString;
        public SumOfString(string inputString)
        {
            bool isValidString = true;
            if (isValidString)
            {
                this.inString = inputString;
            }
        }

        private List<int> inStringNums = new List<int>();

        private void FillOutlist()
        {
            inStringNums = inString.Split(' ').Select(p => int.Parse(p)).ToList();
        }

        public long CalcSumOfString()
        {
            FillOutlist();
            long sum = inStringNums.Sum();

            return sum;
        }
    }
}
