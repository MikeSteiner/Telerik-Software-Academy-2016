using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanToString
{
    public static class BoolToStringConverter
    {
        public static string Convert(bool boolToConvert)
        {
            string outputString = string.Empty;

            outputString = boolToConvert.ToString();

            return outputString;
        }

        public static void WritestringOnCosole(string stringToWrite)
        {
            Console.WriteLine(stringToWrite);
        }
    }
}
