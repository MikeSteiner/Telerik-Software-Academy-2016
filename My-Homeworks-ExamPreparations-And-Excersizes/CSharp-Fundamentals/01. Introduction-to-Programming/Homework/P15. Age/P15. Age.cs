using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


class Age
{
    static void Main(string[] args)
    {
        string inLine = Console.ReadLine();

        string dtFormat = "MM.dd.yyyy";        
        DateTime myBdDate = DateTime.ParseExact(inLine, dtFormat, CultureInfo.InvariantCulture);

        //TimeSpan dtDiff = DateTime.Now.Subtract(myBdDate);        
        //int ageNow = Convert.ToInt32(dtDiff.TotalDays / 365d);
        int earsOldNow = DateTime.Now.Year - myBdDate.Year;

        if (myBdDate.Month > DateTime.Now.Month || (myBdDate.Month == DateTime.Now.Month && myBdDate.Day > DateTime.Now.Day))
        {
            earsOldNow--;
        }

        int ageAferTenYears = earsOldNow + 10;

        Console.WriteLine("{0}", earsOldNow);
        Console.WriteLine("{0}", ageAferTenYears);
    }
}

