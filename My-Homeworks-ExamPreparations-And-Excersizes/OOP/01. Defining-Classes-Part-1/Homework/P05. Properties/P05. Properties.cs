/*
Use properties to encapsulate the data fields inside the GSM, Battery and Display classes.
Ensure all fields hold correct data at any given time.

 */

namespace P05_Properties
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Battery gsmBattery = new Battery();
            gsmBattery.Type = BatteryType.LiIon;
            gsmBattery.PrintInfo();

            Display gsmDisplay = new Display(5, 32000);
            gsmDisplay.PrintInfo();

            GSM gsmLG = new GSM();
            gsmLG.Manufacturer = "LG";
            gsmLG.Owner = "Alexander Toplijski";
            gsmLG.Price = 500;
            gsmLG.PrintInfo();


        }
    }
}
