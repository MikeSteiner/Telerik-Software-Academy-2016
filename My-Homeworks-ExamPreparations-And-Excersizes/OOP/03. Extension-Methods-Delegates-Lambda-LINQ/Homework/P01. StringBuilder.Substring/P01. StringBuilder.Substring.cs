/*
 *
Implement an extension method Substring(int index, int length) for the class StringBuilder 
that returns new StringBuilder and has the same functionality as Substring in the class String. 
 * 
 */

namespace StartingPointNs
{
    using System;
    using System.Text;
    using ExtensionsNs;

    class StartingPoint
    {
        static void Main(string[] args)
        {
            StringBuilder sbInput = new StringBuilder("Implement an extension method Substring");
            StringBuilder sbInputExtraction = sbInput.Substring(0, 9);

            Console.WriteLine(sbInput);
            Console.WriteLine(sbInputExtraction);
        }
    }
}
