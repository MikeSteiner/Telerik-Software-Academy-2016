/*
First larger than neighbours
Description

Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there is no such element.

Input

On the first line you will receive the number N - the size of the array
On the second line you will receive N numbers sepated by spaces - the array
Output

Print the index of the first element that is larger than its neighbours or -1 if none are
Constraints

1 <= N <= 1024
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
6
-26 -25 -28 31 2 27	
1
Submission
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06.First_larger_than_neighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<int> nums = ReadInLineArray();
            Console.WriteLine(FirstLargerThenNeighbrs(nums));

        }

        static List<int> ReadInLineArray()
        {
            string inLine = Console.ReadLine();
            //string inLine = "-26 -25 -28 31 2 27	2";

            char[] delimiters = new char[] { ' ', ',' };
            List<int> nums = inLine.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Select(d => int.Parse(d)).ToList();

            return nums;
        }

        static int CountLargerThenNeighbrs(List<int> numbers)
        {
            int countLargerThenNeighbrc = 0;
            bool isLargerThenNeighbrs = false;

            int firstIx = 0;
            int lastIx = numbers.Count - 1;

            //Array from one element
            if (firstIx == lastIx)
            {
                return countLargerThenNeighbrc;
            }
            //-26 -25 -28 31 2 27	
            for (int i = 0; i < lastIx + 1; i++)
            {
                if (i == firstIx)
                {
                    //isLargerThenNeighbrs = (numbers[i] > numbers[i + 1]);
                }
                else if (i == lastIx)
                {
                    //isLargerThenNeighbrs = (numbers[i] > numbers[i - 1]);
                }
                else
                {
                    isLargerThenNeighbrs = ((numbers[i - 1] < numbers[i]) && (numbers[i] > numbers[i + 1]));

                }

                if (isLargerThenNeighbrs)
                {
                    countLargerThenNeighbrc++;
                    isLargerThenNeighbrs = false;
                }
            }

            return countLargerThenNeighbrc;
        }

        static int FirstLargerThenNeighbrs(List<int> numbers)
        {
            int firstLargerThenNeighbrc = 0;
            bool isLargerThenNeighbrs = false;

            int firstIx = 0;
            int lastIx = numbers.Count - 1;

            //Array from one element
            if (firstIx == lastIx)
            {
                return firstLargerThenNeighbrc;
            }
            //-26 -25 -28 31 2 27	
            for (int i = 0; i < lastIx + 1; i++)
            {
                if (i == firstIx)
                {
                    //isLargerThenNeighbrs = (numbers[i] > numbers[i + 1]);
                }
                else if (i == lastIx)
                {
                    //isLargerThenNeighbrs = (numbers[i] > numbers[i - 1]);
                }
                else
                {
                    isLargerThenNeighbrs = ((numbers[i - 1] < numbers[i]) && (numbers[i] > numbers[i + 1]));

                }

                if (isLargerThenNeighbrs)
                {
                    firstLargerThenNeighbrc = i;                    
                    break;
                }
            }

            return firstLargerThenNeighbrc;
        }
    }
}
