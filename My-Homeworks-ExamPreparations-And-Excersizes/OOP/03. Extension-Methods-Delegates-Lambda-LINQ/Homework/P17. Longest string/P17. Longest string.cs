/*
Write a program to return the string with maximum length from an array of strings.
Use LINQ.
 */

namespace P17.Longest_string
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using StudentsTelerikAcademy;

    class Program
    {
        private static string[] GetStrings()
        {
            var result = new string[10];
            result[0] = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam id.";
            result[1] = "Sed et feugiat lacus, vel rhoncus elit. Nulla quis ultrices magna. In fringilla nibh elit, in tempus quam posuere a.";
            result[2] = "Proin pharetra dui id est volutpat, sit amet ultrices lacus egestas. Proin luctus tellus et malesuada elementum.";
            result[3] = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam nec elementum orci.";
            result[4] = "Mauris consectetur pretium justo eget tempus. Proin gravida euismod sapien ultrices facilisis.";
            result[5] = "Nunc ante sem, aliquam ut ornare nec, congue a ante. Nam viverra felis vitae arcu sodales, vitae maximus libero bibendum.";
            result[6] = "Cras arcu turpis, scelerisque et nisl eu, sodales scelerisque arcu.";
            result[7] = "Pellentesque venenatis sodales magna et venenatis. Donec ante elit, consectetur nec vulputate id, rhoncus at quam.";
            result[8] = "Vestibulum blandit semper ex et tempus. Nulla tempor, erat accumsan tincidunt ultrices, arcu mauris commodo diam, quis blandit magna eros ut odio.";
            result[9] = "Mauris congue malesuada ex, vel porta nisi cursus faucibus.";

            return result;
        }

        // the new way to make methods from C# 6 
        private static void PrintLine() => Console.WriteLine("-----------------------");

        static void Main(string[] args)
        {
            // Create sample students            
            
            var strings = GetStrings();

            // Print longest string in array of strings
            var result = strings
                .OrderByDescending(x => x.Length)
                .FirstOrDefault();
            Console.WriteLine(result);
            PrintLine();
        }
    }
}
