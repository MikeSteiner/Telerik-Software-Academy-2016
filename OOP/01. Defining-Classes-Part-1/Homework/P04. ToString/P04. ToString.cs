/*
 * 
Add a method in the GSM class for displaying all information about it.
Try to override ToString(). 
 
*/

namespace P04_ToString
{
    using System;    

    class GsmMain
    {
        static void Main(string[] args)
        {
            Display gsmDisplay = new Display(5, 32000);
            gsmDisplay.PrintInfo();
            
            Battery gsmBattery = new Battery("LG G2 genuine battery", 500, 100, BatteryType.LiIon);
            gsmBattery.PrintInfo();

            GSM gsmLG = new GSM("LG G2", "LG", 500, "ATo");
            gsmLG.PrintInfo();

            Console.WriteLine("-------------------------");
            Console.WriteLine(gsmDisplay.ToString());
            Console.WriteLine(gsmBattery.ToString());
            Console.WriteLine(gsmLG.ToString());

        }
    }
}
