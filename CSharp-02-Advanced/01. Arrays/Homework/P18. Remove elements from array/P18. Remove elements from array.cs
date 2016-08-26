/*
Remove elements from array
Description

Write a program that reads an array of integers and removes from it a minimal number of elements in such a way that the remaining array is sorted in increasing order. Print the minimal number of elements that need to be removed in order for the array to become sorted.

Input

On the first line you will receive the number N
On the next N lines the numbers of the array will be given
Output

Print the minimal number of elements that need to be removed
Constraints

1 <= N <= 1024
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
8
1
4
3
3
6
3
2
3	

3

10
14
2
9
8
3
13
17
19
30
1	

4
Submission
 */
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace P18.Remove_elements_from_array
//{
//    class RemoveElementsFromArray
//    {
//        static void MaskIncrement(int startIx, int endIx, int pivotIx, bool[] maskArr, int[] mainArr)
//        {
//            int pivotValue = mainArr[pivotIx];
//            int currMaxValue = int.MinValue; // mainArr[pivotIx];
//            for (int i = startIx; i < endIx; i++)
//            {
//                int currValue = mainArr[i];
//                //if (pivotValue <= currValue && currValue >= currMaxValue)
//                if (i < pivotIx)
//                {
//                    if (currValue <= pivotValue && currValue >= currMaxValue)
//                    {
//                        maskArr[i] = true;
//                        currMaxValue = currValue;
//                    }
//                }
//                else if (i > pivotIx)
//                {
//                    if (currValue >= pivotValue && currValue >= currMaxValue)
//                    {
//                        maskArr[i] = true;
//                        currMaxValue = currValue;
//                    }
//                }
//                else
//                {
//                    maskArr[i] = true;
//                    currMaxValue = pivotValue;
//                }

//            }
//        }

//        static void MaskDecrement(int startIx, int endIx, int pivotIx, bool[] maskArr, int[] mainArr)
//        {
//            int pivotValue = mainArr[pivotIx];
//            int currMinValue = int.MaxValue;
//            for (int i = endIx - 1; i >= startIx; i--)
//            {
//                int currValue = mainArr[i];
//                //if (currMinValue >= currValue &&  currValue >= pivotValue)
//                if (i < pivotIx)
//                {
//                    if (currValue <= pivotValue && currValue >= currMinValue)
//                    {
//                        maskArr[i] = true;
//                        currMinValue = currValue;
//                    }
//                }
//                else if (i > pivotIx)
//                {
//                    if (currValue >= pivotValue && currValue <= currMinValue)
//                    {
//                        maskArr[i] = true;
//                        currMinValue = currValue;
//                    }
//                }
//                else
//                {
//                    maskArr[i] = true;
//                    currMinValue = pivotValue;
//                }

//            }
//        }

//        static string FindMask(int minIx, int middleIx, int maxIx, int[] arr)
//        {            
//            string longestMask = "";

//            bool[] maskIncL = new bool[maxIx];
//            bool[] maskDecL = new bool[maxIx];
//            bool[] maskIncR = new bool[maxIx];
//            bool[] maskDecR = new bool[maxIx];
//            bool[] maskInc = new bool[maxIx];
//            bool[] maskDec = new bool[maxIx];


//            if (minIx == middleIx || middleIx == maxIx)    //From 0 => max inc OR From 0 <= max dec
//            {
//                //Incremet from 0 => max
//                MaskIncrement(minIx, maxIx, middleIx, maskInc, arr);


//                //Decrement from 0 <= max
//                MaskDecrement(minIx, maxIx, middleIx, maskDec, arr);


//                //Check for longest mask
//                int counterMaskInc = maskInc.Count(el => el == true);
//                int counterMaskDec = maskDec.Count(el => el == true);

//                if (counterMaskInc >= counterMaskDec)
//                {
//                    longestMask = string.Join("", maskInc.Select(p => p == true ? '1' : '0').ToArray());
//                }
//                else
//                {
//                    longestMask = string.Join("", maskDec.Select(p => p == true ? '1' : '0').ToArray());
//                }

//            }
//            //From start => middle && middle <= end
//            else            
//            {
//                //Incremet from 0 => middle                
//                MaskIncrement(minIx, middleIx, middleIx, maskIncL, arr);  //L part
//                //Decrement from 0 <= middle
//                MaskDecrement(minIx, middleIx, middleIx, maskDecL, arr);  //L part
//                //Check for longest mask L
//                int counterMaskIncL = maskIncL.Count(el => el == true);
//                int counterMaskDecL = maskDecL.Count(el => el == true);



//                //Incremet from 0 => middle                
//                MaskIncrement(middleIx, maxIx, middleIx, maskIncR, arr);  //R part
//                //Decrement from 0 <= middle
//                MaskDecrement(middleIx, maxIx, middleIx, maskDecR, arr);  //R part
//                //Check for longest mask L
//                int counterMaskIncR = maskIncR.Count(el => el == true);
//                int counterMaskDecR = maskDecR.Count(el => el == true);

//                bool[] mL = new bool[maxIx];
//                if (counterMaskIncL >= counterMaskDecL)
//                {
//                    mL = maskIncL;
//                }
//                else
//                {
//                    mL = maskDecL;
//                }

//                bool[] mR = new bool[maxIx];
//                if (counterMaskIncR >= counterMaskDecR)
//                {
//                    mR = maskIncR;
//                }
//                else
//                {
//                    mR = maskDecR;
//                }

//                //Concat the final longest mask
//                for (int i = 0; i < mL.Length; i++)
//                {
//                    bool finalElement = mL[i] | mR[i];
//                    longestMask = longestMask + (finalElement == true ? '1' : '0').ToString();
//                }


//            }

//            return longestMask;
//        }

//        static void Main(string[] args)
//        {
//            int N = int.Parse(Console.ReadLine());
//            int[] nums = new int[N];

//            //Fill out array
//            for (int i = 0; i < nums.Length; i++)
//            {
//                nums[i] = int.Parse(Console.ReadLine());
//            }


//            //Find best mask
//            int min = 0;
//            int middle;
//            int max = nums.Length;

//            string bestMask = "";
//            int bestMaskLenght = int.MaxValue;
//            string currMask = "";
//            int currmaskLenght = int.MaxValue;

//            for (int i = 0; i < max; i++)
//            //for (int i = 0; i < 1; i++)
//            {
//                middle = i;
//                currMask = FindMask(min, middle, max, nums);

//                //Get mask lenght
//                currmaskLenght = currMask.Count(el => el == '0');
//                //Console.WriteLine(new string('-', 10));
//                //Console.WriteLine(currMask);
//                //Console.WriteLine(currmaskLenght);

//                if (currmaskLenght < bestMaskLenght)
//                {
//                    bestMask = currMask;
//                    bestMaskLenght = currmaskLenght;
//                }

//            }


//            //Print out
//            //Console.WriteLine(bestMask);
//            //Console.WriteLine("lenght: {0}", bestMaskLenght);
//            Console.WriteLine(bestMaskLenght);
//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;

class RemoveElementsFromArray
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] nums = new int[N];

        //Fill out array
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        //int[] nums = new int[] { 1, 4, 3, 3, 6, 3, 2, 3 };
        // result = 3

        //int[] nums = new int[] { 14, 2, 9, 8, 3, 13, 17, 19, 30, 1 };
        //result = 4

        int bestSeqLenght = 1;

        //Check for increasing sequences
        for (int mask = 1; mask < Math.Pow(2, nums.Length); mask++)      //All possible combinations
        {
            string maskBoolStr = Convert.ToString(mask, 2).PadLeft(nums.Length, '0');
            bool[] maskBoolArr = maskBoolStr.Select(ch => Convert.ToBoolean(Char.GetNumericValue(ch))).ToArray(); 
            //Console.WriteLine(maskBoolStr);

            //Put the current combination in a list collection
            List<int> currentCombo = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (maskBoolArr[i])
                {
                    currentCombo.Add(nums[i]);
                }
            }

            //Console.WriteLine(currSum);
            //Console.WriteLine(new string('-', 10));

            //Check if curretn combination is increasing sequence
            bool isIncrSequence = true;
            for (int i = 1; i < currentCombo.Count; i++)
            {
                if(!(currentCombo[i] >= currentCombo[i - 1]))
                {
                    isIncrSequence = false;
                    break;
                }
            }
            //1, 4, 3, 3, 6, 3, 2, 3
            //Compare curretn inc sequence lenght with the best lenght
            if (isIncrSequence && (currentCombo.Count >= bestSeqLenght))
            {
                bestSeqLenght = currentCombo.Count;
            }

        }

        Console.WriteLine(nums.Length - bestSeqLenght);

    }
}
