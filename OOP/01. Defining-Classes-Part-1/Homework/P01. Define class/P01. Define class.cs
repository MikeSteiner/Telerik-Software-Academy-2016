/*
Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors).
Define 3 separate classes (class GSM holding instances of the classes Battery and Display).
 */
 

namespace P01_DefineClass
{
    using System;

    class GsmMain
    {
        static void Main(string[] args)
        {
            Display displayLG = new Display();
            Battery batteryLG = new Battery();
            GSM gsmLG = new GSM();

        }
    }
}
