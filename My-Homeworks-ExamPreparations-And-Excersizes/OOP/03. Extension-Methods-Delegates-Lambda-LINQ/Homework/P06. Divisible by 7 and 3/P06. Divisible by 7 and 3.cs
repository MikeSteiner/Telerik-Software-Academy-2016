/*
Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
 * 
 */


namespace P06.Divisible_by_7_and_3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MathOperations
    {
        public int[] nums = new int[] { 1, 3, 5, 7, 8, 12, 21, 63 };

        public void PrintDivBySevenAndThree()
        {
            foreach (int num in nums)
            {
                bool isDivBySeven = (num % 7 == 0);
                bool isDivByThree = (num % 3 == 0);
                if (isDivBySeven && isDivByThree)
                {
                    Console.WriteLine("true {0}", num);
                }
            }
        }

        public int[] PrintDivBySevenAndThreeLinq()
        {
            int[] numsSellected = nums.Where(d => (d % 3 == 0) && (d % 7 == 0)).ToArray();
                
            return numsSellected;
        }

    }
    

    public static class StartingPoint
    {
        public static void Main(string[] args)
        {
            MathOperations mo = new MathOperations();
            mo.PrintDivBySevenAndThree();

            int[] returns = mo.PrintDivBySevenAndThreeLinq();
            Console.WriteLine(string.Join(" ", returns));
        }
    }
}
