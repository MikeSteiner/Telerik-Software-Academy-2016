/*
Write a class GSMTest to test the GSM class:
Create an array of few instances of the GSM class.
Display the information about the GSMs in the array.
Display the information about the static property IPhone4S.
*/

namespace P07_GsmTest
{
    using System;
    using System.Collections.Generic;

    class GsmTest
    {
        static void Main(string[] args)
        {
            //Single smart phone
            SmartPhone mySmartPhone = new SmartPhone("LG", "G2");
            mySmartPhone.Owner = "Alexander";
            mySmartPhone.Price = 450;
            mySmartPhone.Raiting = 7.5d;
            mySmartPhone.HoursIdle = 250;
            mySmartPhone.HoursTalk = 100;
            mySmartPhone.DisplaySize = 5.1d;
            mySmartPhone.NumberOfColors = 32000;

            string smInfo = mySmartPhone.GetSmartPhoneInfo();           

            //Best smart phones 1999
            List<SmartPhone> smartPhones = new List<SmartPhone>();

            smartPhones.Add(new SmartPhone("LG", "G2"));
            smartPhones[0].Owner = "Alexander Toplijski";
            smartPhones[0].Price = 450;
            smartPhones[0].Raiting = 7.5d;
            smartPhones[0].HoursIdle = 250;
            smartPhones[0].HoursTalk = 100;
            smartPhones[0].DisplaySize = 5.1d;
            smartPhones[0].NumberOfColors = 32000;


            smartPhones.Add(new SmartPhone("Samisung", "Galaxy S7"));
            smartPhones[1].Owner = "My Friend";
            smartPhones[1].Price = 1050;
            smartPhones[1].Raiting = 8.5d;
            smartPhones[1].HoursIdle = 301;
            smartPhones[1].HoursTalk = 150;
            smartPhones[1].DisplaySize = 5.2d;
            smartPhones[1].NumberOfColors = 32000;
            
            smartPhones.Add(new SmartPhone("Huawey",  "P9"));
            smartPhones[2].Owner = "Another Friend";
            smartPhones[2].Price = 1050;
            smartPhones[2].Raiting = 6.5d;
            smartPhones[2].HoursIdle = 3000;
            smartPhones[2].HoursTalk = 1500;
            smartPhones[2].DisplaySize = 5.5d;
            smartPhones[2].NumberOfColors = 32000;

            smartPhones.Add(new SmartPhone("Apple", "IPhone4S"));
            smartPhones[3].Owner = "yet Another Friend of a friend, of mine, is a girl :)";
            smartPhones[3].Price = 1550;
            smartPhones[3].Raiting = 10.0d;
            smartPhones[3].HoursIdle = 3003;
            smartPhones[3].HoursTalk = 1001;
            smartPhones[3].DisplaySize = 5.3d;
            smartPhones[3].NumberOfColors = 64000;


            foreach (SmartPhone smartPhone in smartPhones)
            {
                string smartInfo = smartPhone.GetSmartPhoneInfo();
                Console.WriteLine(smartInfo);
            }
            Console.WriteLine();
            Console.WriteLine("We have {0} IPhone S4 in the list", GSM.iPhone4sCount);

        }
    }
}
