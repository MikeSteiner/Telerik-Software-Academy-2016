using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Declare five variables choosing for each of them the most appropriate of the types 
byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 
52130, -115, 4825932, 97, -10000. 
Choose a large enough type for each number to ensure it will fit in it.Try to compile the code.
*/ 
class DeclareVariables
{
    static void Main(string[] args)
    {

        int varOne = 52130;
        short varTwo = -115;
        long varTree = 4825932;
        byte varFour = 97;
        int varFive = -10000;
        
        Console.WriteLine("Var: {0}; MaxValue: {1}", varOne, int.MaxValue);
        Console.WriteLine("Var: {0}; MaxValue: {1}", varTwo, short.MaxValue);
        Console.WriteLine("Var: {0}; MaxValue: {1}", varTree, long.MaxValue);
        Console.WriteLine("Var: {0}; MaxValue: {1}", varFour, byte.MaxValue);
        Console.WriteLine("Var: {0}; MaxValue: {1}", varFive, int.MaxValue);
        
    }
}

