using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooleanToString;

namespace UsagePart
{
    public class TestBoolToStringConverter
    {
        private const int MaxCount = 6;

        public static void Main()
        {
            bool firstVariableToTest = true;
            string firstConversionResult = BoolToStringConverter.Convert(firstVariableToTest);

            BoolToStringConverter.WritestringOnCosole(firstConversionResult);
        }
    }
}
