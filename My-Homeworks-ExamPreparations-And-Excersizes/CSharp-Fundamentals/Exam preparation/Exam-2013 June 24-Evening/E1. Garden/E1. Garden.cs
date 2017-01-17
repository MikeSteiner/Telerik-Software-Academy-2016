/*
    Problem 1 – Garden

    Uncle Pesho needs help to calculate his garden production. He grows different vegetable plants. You are assigned to write a program to help him with the production calculations. 
    Uncle Pesho wants to plant the following vegetables: tomato, cucumber, potato, carrot, cabbage, beans. 
    For each vegetable, except the beans, uncle Pesho knows:
    •	how many seeds he wants to plant 
    •	on what area he wants to plant those seeds
    For the beans, uncle Pesho has decided:
    •	how many seeds he wants to plant
    •	the area for the beans will be the area remaining after planting the other vegetables
    The total area uncle Pesho has is 250 square meters.
    Of course, everything in life has a price – including seeds. Below you will find a table with prices per seed for each vegetable
    Write a program to calculate the total cost of all the seeds Pesho needs to buy and the total area remaining for the beans.
    Seeds Costs	
    tomato	0.5$ per seed		carrot	0.6$ per seed
    cucumber	0.4$ per seed		cabbage	0.3$ per seed
    potato	0.25$ per seed		beans	0.4$ per seed
    Input
    The input data consists of 11 lines describing all the vegetables. Each line will hold a single number:
    •	The first line holds the tomato seeds amount, the second – the tomato area.
    •	The third line holds the cucumber seeds amount, the fourth line – cucumber area. 
    •	The fifth line holds the potato seeds amount, sixth line – potato area.
    •	The seventh line holds the carrot seeds amount, eighth line – carrot area.
    •	The ninth line holds the cabbage seeds amount, tenth line – cabbage area. 
    •	The eleventh line holds the beans seeds amount.
    The input data will always be valid and in the format described. There is no need to check it explicitly.
    Output
    The output data should be printed at the console in two lines:
    •	At the first line print the total seeds cost, rounded to second digit after the decimal separator, in format “Total costs: X.XX” where X.XX are the costs.
    •	At the second line print the remaining area for beans.
    o	In case there is some area for beans left, print its size in format “Beans area: X” where X is the area left for beans.
    o	In case of no area for beans is left, print „No area for beans“.
    o	In case the area for the tomato, cucumber, potato, carrot and cabbage is insufficient, print “Insufficient area”.
    Constraints
    •	The seeds amount is non-negative integer number in the range [0…1000].
    •	The plants area is non-negative integer number in the range [0…250].
    •	All numbers should use as a decimal separator the symbol “.” (point, no comma).
    •	Allowed work time for your program: 0.1 seconds.
    •	Allowed memory: 4 MB.

Examples
Input	Output		Input	Output		Input	Output
10
20
25
30
42
38
15
23
18
36
70	Total costs: 67.90
Beans area: 103		30
39
50
60
15
77
18
36
28
39
65	Total costs: 83.95
Insufficient area		0
0
50
0
0
100
200
50
30
100
65	Total costs: 175.00
No area for beans
 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1.Garden
{
    class Garden
    {
        static void Main(string[] args)
        {
            const int batPeshosArea = 250;
            bool insufficientArea = false;

            double totalCosts = 0.0;
            int totalUsedArea = 0;

            //Tomatos
            double tomaotoPricePerSeed = 0.50; //USD
            int tomatoSeeds = int.Parse(Console.ReadLine());
            int tomatoArea = int.Parse(Console.ReadLine());
            totalCosts += tomaotoPricePerSeed * tomatoSeeds;
            totalUsedArea += tomatoArea;
            insufficientArea = (totalUsedArea > batPeshosArea);
            

            //sucumbers
            double cucumberPricePerSeed = 0.40; //USD
            int cucumberSeeds = int.Parse(Console.ReadLine());
            int cucumberArea = int.Parse(Console.ReadLine());
            totalCosts += cucumberPricePerSeed * cucumberSeeds;
            totalUsedArea += cucumberArea;
            insufficientArea = (totalUsedArea > batPeshosArea);

            //Potatos
            double potatoPricePerSeed = 0.25; //USD
            int potatoSeeds = int.Parse(Console.ReadLine());
            int potatoArea = int.Parse(Console.ReadLine());
            totalCosts += potatoPricePerSeed * potatoSeeds;
            totalUsedArea += potatoArea;
            insufficientArea = (totalUsedArea > batPeshosArea);

            //Carrots
            double carrotoPricePerSeed = 0.60; //USD
            int carrotSeeds = int.Parse(Console.ReadLine());
            int carrotArea = int.Parse(Console.ReadLine());
            totalCosts += carrotoPricePerSeed * carrotSeeds;
            totalUsedArea += carrotArea;
            insufficientArea = (totalUsedArea > batPeshosArea);

            //Cabbage
            double cabbagePricePerSeed = 0.30; //USD
            int cabbageSeeds = int.Parse(Console.ReadLine());
            int cabbageArea = int.Parse(Console.ReadLine());
            totalCosts += cabbagePricePerSeed * cabbageSeeds;
            totalUsedArea += cabbageArea;
            insufficientArea = (totalUsedArea > batPeshosArea);

            double beansPricePerSeed = 0.40; //USD
            int beansSeeds = int.Parse(Console.ReadLine());
            totalCosts += beansPricePerSeed * beansSeeds;
            int beansArea = batPeshosArea - totalUsedArea;

            //Print out
            Console.WriteLine("Total costs: {0:#0.00}", totalCosts);
            if (beansArea > 0)
            {
                Console.WriteLine("Beans area: {0}", beansArea);
            }
            else
            {
                if (insufficientArea)
                {
                    Console.WriteLine("Insufficient area");
                }
                else
                {
                    Console.WriteLine("No area for beans");
                }
            }
            
        }
    }
}
