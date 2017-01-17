using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassSize;

namespace VariablesDataExpressionsConstants
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Size Test
            Size s = new Size(20, 30);
            Console.WriteLine(Size.GetRotatedSize(s, 45).ToString());

            // 
        }
    }
}
