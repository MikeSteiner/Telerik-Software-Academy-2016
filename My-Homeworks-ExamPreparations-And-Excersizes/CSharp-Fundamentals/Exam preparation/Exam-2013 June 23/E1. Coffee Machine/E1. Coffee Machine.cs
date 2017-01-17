﻿/*
    Problem 1 – Coffee Vending Machine
    The coffee vending machine at Telerik Academy does not work properly – its module for giving change has problems. The staff has already called a technician but he is in one of the hundreds of traffic jams in the centre of Sofia. Since there is an examination today, there is a long queue of developers with bloodthirsty looks waiting to get some coffee. Your task is to help temporarily fix the module (before the technician arrives) and calm the developers down.
    The machine has five trays – for 0.05, 0.10, 0.20, 0.50, and 1.00 BGN respectively. We are given the number of coins available in each tray N1, N2, …, N5 inside the machine (N1 corresponds to 0.05, N2 corresponds to 0.10 and so on). We are also given the amount A of money the developer has put into the machine, and the price P of the drink.
    Write a program to calculate whether the machine can give change to the developer. There are three possible cases:
    •	The machine has enough coins in its trays to give the change.
    •	The machine waits for the developer to put more coins (in order to reach the amount A).
    •	The machine does not have enough coins to give the change.
    Input
    The input data should be read from the console. 
    On the first five lines there will be the numbers N1, N2, …, N5, each on its own line.
    On the sixth line there will be the amount A the developer has put in the machine.
    On the seventh line there will be the price P of the selected drink.
    The input data will always be valid and in the format described. There is no need to check it explicitly.
    Output
    The output data should be printed on the console.
    On the only output line your program should print one of the following words and prices, separated by a single space:
    •	If the developer has given enough money and the machine can give change (or there is no change), print Yes along with the money left in the machine’s trays after giving change.
    •	If the price of the drink is more than the amount put by the developer, print More along with the additional amount of money needed.
    •	If the developer has given enough money but the machine cannot give change, print No along with the amount of insufficient money in the machine’s trays (e. g. if the machine has 1 BGN totally in its trays but has to give 2.50 BGN, the amount of insufficient money is 1.50 BGN).
    All prices should be printed with exactly two numbers after the decimal point. The decimal separator for all numbers is point “.”. Do not put any currency signs.
    Constraints
    •	The numbers N1, N2, …, N5 will always be integers in the range [0; 10000]
    •	The numbers A and P will always be valid prices (with exactly two digits after the decimal point) in the range [0.05; 1000.00] (yes, some drinks can be expensive :))
    •	Allowed working time for your program: 0.1 seconds
    •	Allowed memory: 4 MB
Examples
Input	Output		Input	Output		Input	Output
4
5
4
2
1
3.00
1.90	Yes 2.40		4
5
4
2
1
3.00
4.00	More 1.00		4
5
4
2
1
10.00
2.00	No 4.50


 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1.Coffee_Machine
{
    class CoffeeMachine
    {
        static void Main(string[] args)
        {
            decimal[] levaPerTray = {0.00m,
                                0.05m,
                                0.10m,
                                0.20m,
                                0.50m,
                                1.00m};

            decimal[] moneyInTrays = new decimal[7];
            moneyInTrays[0] = 0.0m;

            for (int i = 1; i <= 5; i++)
            {
                int N = int.Parse(Console.ReadLine());
                moneyInTrays[i] = levaPerTray[i] * N;

            }
            decimal moneyInTheMashine = moneyInTrays.Sum();
            decimal moneyInput = decimal.Parse( Console.ReadLine());
            decimal priceOfDrink = decimal.Parse(Console.ReadLine());

            if (moneyInput>=priceOfDrink)
            {
                decimal returnChange = moneyInput - priceOfDrink;
                if (moneyInTheMashine>= returnChange)
                {
                    //Yes will return all change
                    Console.WriteLine("Yes {0:#0.00}", moneyInTheMashine-returnChange);
                }
                else
                {
                    //No dont have money to return change
                    Console.WriteLine("No {0:#0.00}", returnChange - moneyInTheMashine);
                }
            }
            else
            {
                //Put more moniey
                Console.WriteLine("More {0:#0.00}", priceOfDrink -moneyInput);
            }

        }
    }
}