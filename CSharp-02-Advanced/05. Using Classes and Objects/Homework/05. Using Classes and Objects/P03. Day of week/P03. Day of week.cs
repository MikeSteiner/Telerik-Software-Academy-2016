using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03.Day_of_week
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            Enum prDay = ReturnPresentDay();
            Console.WriteLine(prDay);
        }

        static Enum ReturnPresentDay()
        {
            Enum presentdayOfWeek = DateTime.Today.DayOfWeek;          
            return presentdayOfWeek;
        }
        
    }
}
