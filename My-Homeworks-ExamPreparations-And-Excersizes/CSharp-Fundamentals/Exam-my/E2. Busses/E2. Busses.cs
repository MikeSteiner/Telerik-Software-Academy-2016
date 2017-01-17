/*
Task 2: Buses

Description

You know buses and their drivers - they all seem to have different opinion about the speed they move with. That leads to a lot of buses that are grouped together. Since Stamat is a very smart and curious guy, he wants to be able to count the number of groups that are formed from a sequence of buses.

Given the sequence of the speeds of the buses, print on the console the number of groups that are formed.

Additional notes
•Buses cannot outrun the buses in front of them ◦If bus A is moving faster and reaches a bus B that is moving slower, then A must lower its speed to match that of B 

•Buses with equal speed does not form a group ◦Their form different groups


Example:



Input

All input data is read from the standard input (the console)
•On the first line will be the number  C  ◦The number of buses

•On the next  C  lines there will a single integer number  S  ◦The speed of the bus


Output

The output data is printed on the standard output (the console)
•On the single line on the output print the number of groups that the buses form

Constraints
•  C  will always be between  1  and  1000  
•Each  S  will always be between  1  and  1500  
•Allowed memory: 16 MiB 
•Allowed working time for your program: 0.1 seconds 
•The input data will always be correct and there is no need to check it explicitly

Sample Tests

Sample Input 1
11
4
6
5
3
3
9
100
2
4
3
1


Sample Output 1
5


Sample Input 2
4
1
1
1
1


Sample Output 2
4


Sample Input 3
5
5
4
3
2
1


Sample Output 3
5


Sample Input 4
5
1
2
3
4
5


Sample Output 4
1 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2.Busses_Description
{
    class Busses
    {
        static void Main(string[] args)
        {
            //Init
            int buses = int.Parse(Console.ReadLine());
            int[] bSpeeds = new int[buses];
            int[] bGroups = new int[buses];
            int groupsCouter = 0;

            //Fill out
            for (int i = 0; i < buses; i++)
            {
                bSpeeds[i] = int.Parse(Console.ReadLine());
                bGroups[i] = (0);
            }

            //Array.Reverse(bSpeeds);

            //Process
            for (int i = 0; i < buses; i++)
            {
                //When is the beginning A is the first bus
                if (i == 0)
                {
                    int busA = bSpeeds[i];
                    int busB = bSpeeds[i + 1];
                    if (busA > busB)
                    {
                        bGroups[i] = 1;     //1 = added to group number 1                        
                        groupsCouter++;
                    }
                    else if (busA < busB)
                    {
                        bGroups[i] = 1;     //1 = added to group number 1
                        bGroups[i + 1] = 1;
                        groupsCouter = 1;
                    }
                    else
                    {
                        groupsCouter = 1;
                        bGroups[i] = 1;    //-1 = Counted and excluded                       
                    }
                }
                //When is the middle of the busses
                else if(0 < i && i < buses - 1){

                    int busB = bSpeeds[i];
                    int busC = bSpeeds[i + 1];
                    //B > C
                    if (busB > busC)
                    {
                        if (bGroups[i] == (0))
                        {
                            groupsCouter++;
                            bGroups[i] = groupsCouter;      //added to new group with num ++                            
                            
                        }
                        else
                        {
                            int minSpeedInGrp = int.MaxValue;
                            for (int grp = 0; grp < buses; grp++)
                            {
                                if(bGroups[i] == bGroups[grp])
                                {
                                    minSpeedInGrp = Math.Min(minSpeedInGrp, bSpeeds[grp]);
                                }
                            }

                            if(busC >= minSpeedInGrp)
                            {
                                bGroups[i+1] = bGroups[i];
                            }
                            else
                            {
                                groupsCouter++;
                                bGroups[i + 1] = groupsCouter;
                            }
                        }
                        
                    }
                    //B < C
                    else if (busB < busC)
                    {
                        if (bGroups[i] == 0)
                        {
                            groupsCouter++;
                            bGroups[i] = groupsCouter;
                            bGroups[i + 1] = groupsCouter;
                        }
                        else
                        {
                            bGroups[i + 1] = bGroups[i];
                        }
                    }
                    //B = C
                    else
                    {
                        if (bGroups[i] == 0)
                        {
                            groupsCouter++;
                            bGroups[i] = groupsCouter;        //-1 = Counted and excluded                            
                        }
                    }
                }
                //When is the last index
                else
                {
                    int busY = bSpeeds[i];
                    if (bGroups[i] == 0)
                    {
                        groupsCouter++;
                        bGroups[i] = groupsCouter;
                    }                    
                }
            }

            //Print out
            //Console.WriteLine("{0}", string.Join(", ", bGroups.ToString()));
            Console.WriteLine(groupsCouter);
        }
    }
}
