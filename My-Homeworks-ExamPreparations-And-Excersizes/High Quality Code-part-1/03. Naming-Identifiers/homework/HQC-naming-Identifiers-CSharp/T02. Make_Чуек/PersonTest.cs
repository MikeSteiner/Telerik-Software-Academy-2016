using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonCreator.Common;

namespace PersonCreator.Test
{
    public class PersonTest
    {
        public static void Main()
        {
            Person alexander = new Person("Alexander", 36, Gender.Male);
            Console.WriteLine(alexander);

            // My HQC understanding for batka :)
            Person batka = new Person(28);
            Console.WriteLine(batka);

            // My HQC understanding for macka :)
            Person macka = new Person(27);
            Console.WriteLine(macka);
        }
    }
}
