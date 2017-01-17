using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**************************************************************
    Odd and Even Product

    Description

    You are given N integers (given in a single line, separated by a space).

    Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
    Elements are counted from 1 to N, so the first element is odd, the second is even, etc.
    Input

    On the first line you will receive the number N
    On the second line you will receive N numbers separated by a whitespace
    Output

    If the two products are equal, output a string in the format "yes PRODUCT_VALUE", otherwise write on the console "no ODD_PRODUCT_VALUE EVEN_PRODUCT_VALUE"
    Constraints

    N will always be a valid integer number in the range [4, 50]
    All input numbers from the second line will also be valid integers
    Time limit: 0.1s
    Memory limit: 16MB
    Sample tests

Input	Output
5
2 1 1 6 3	yes 6
5
4 3 2 5 2	no 16 15

**************************************************************/
namespace P10.Odd_and_Even_Product
{
    class OddAndEvenProduct
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> numsOdd = new List<int>();
            List<int> numsEven = new List<int>();
            //List<int> numsOdd = nums..Where(p => p % 2 == 1).ToList();
            //List<int> numsEven = nums.Where(p => p % 2 == 0).ToList();

            for (int i = 0; i < nums.Count; i++)
            {
                bool isEven = (i + 1) % 2 == 0;
                bool isOdd = (i + 1) % 2 == 1;

                if (isOdd)
                {
                    numsOdd.Add(nums[i]);
                }
                if (isEven)
                {
                    numsEven.Add(nums[i]);
                }
            }        

            //bool areEqualProducts = (numsEven.Sum() == numsOdd.Sum());

            long prodEven = 1;            
            foreach (var item in numsEven)
            {
                prodEven = prodEven * (long)item;
            }

            long prodOdd = 1;
            foreach (var item in numsOdd)
            {
                prodOdd = prodOdd * (long)item;
            }

            if (prodEven == prodOdd)
            {
                Console.WriteLine("yes {0}", prodEven);
            }
            else
            {
                Console.WriteLine("no {0} {1}", prodOdd, prodEven);
            }
        }
    }
}
