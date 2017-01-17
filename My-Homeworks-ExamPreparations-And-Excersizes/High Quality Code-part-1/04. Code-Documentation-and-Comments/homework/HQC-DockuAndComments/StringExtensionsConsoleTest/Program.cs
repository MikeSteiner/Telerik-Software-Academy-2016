using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.ILS.Common;

namespace StringExtensionsConsoleTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userName = @"This is test 1234435aасв4рфуuserц!@@№$$$%€§*()_+_)((";
            userName = userName.ToValidUsername();
            Console.WriteLine(userName);
        }
    }
}
