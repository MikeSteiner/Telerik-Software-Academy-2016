/*
Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
 * 
 */
using System;
using GSM_NS;

namespace P06_StaticField
{
    class Program
    {
        static void Main(string[] args)
        {
            GSM LG = new GSM("G2");
            LG.Manufacturer = "LG";
            LG.Owner = "Alexander";
            LG.Price = 450;
            string lgModel = LG.Model;

            Console.WriteLine(LG.ToString());

            GSM iPhone4S = new GSM("IPhone4S");
            iPhone4S.Manufacturer = "Apple";
            iPhone4S.Owner = "My neighbour";
            iPhone4S.Price = 1450;
            string iphoneModel = iPhone4S.Model;

            Console.WriteLine(iPhone4S.ToString());


        }
    }
}
