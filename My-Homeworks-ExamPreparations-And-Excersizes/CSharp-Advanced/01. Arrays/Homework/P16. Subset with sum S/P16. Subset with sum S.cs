using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16.Subset_with_sum_S
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int[] nums = Console
                        .ReadLine()
                        .Split(new Char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(p => int.Parse(p))
                        .ToArray();
            int S = int.Parse(Console.ReadLine());
            
            int bestSum = 0;
            string firstBestCombo = ""; 
            //2, 1, 2, 4, 3, 5, 2, 6
            //S==14
            //Precessing
            for (int mask = 1; mask < Math.Pow(2,nums.Length); mask++)      //Possible combinations
            {
                string maskBoolStr = Convert.ToString(mask, 2).PadLeft(8, '0');
                bool[] maskBoolArr = maskBoolStr.Select(ch=>Convert.ToBoolean(Char.GetNumericValue(ch))).ToArray(); //.Select(ch=>Convert.ToBoolean(ch));
                Console.WriteLine(maskBoolStr);

                int currSum = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (maskBoolArr[i])
                    {
                        currSum += nums[i];
                    }                    
                }
                Console.WriteLine(currSum);
                Console.WriteLine(new string('-', 10));
                
                if (currSum == S)
                {
                    bestSum = currSum;
                    firstBestCombo = maskBoolStr;
                    break;
                }

            }

            //Print out
            if (bestSum > 0)
            {
                Console.WriteLine("yes: {0}",bestSum);
            }
            else
            {
                Console.WriteLine("no");
            }
            

        }
    }
}
