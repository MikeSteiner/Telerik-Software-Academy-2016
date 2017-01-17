/*
 * 
Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it).
Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.
 * 
 */ 

using System;


namespace P02_Constructors
{

    class GsmMain
    {
        static void Main(string[] args)
        {
            Battery gsmBattery = new Battery("battery model", 100, 20);
            Display gsmDisplay = new Display(5, 32000);
            GSM gsmLgG2 = new GSM("LG G2", "LG");

        }
    }
}
