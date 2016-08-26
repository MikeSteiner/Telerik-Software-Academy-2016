/*
Implement the previous using the same query expressed with extension methods.
*/



namespace StudentsTelerikAcademy.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Extensions
    {
        // Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
        // Use LINQ query operators.
        public static IEnumerable<T> FirstNameBoforeLast<T>(this IEnumerable<T> students) where T : Student
        {
            var studentsFirstBeforeLast = students.Where(st => CompareStrings(st.FirstName, st.LastName) > 0).ToList();

            return studentsFirstBeforeLast;
        }

        // Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by 
        // first name and last name in descending order.
        // Rewrite the same with LINQ.
        public static IEnumerable<T> OrderedDesc<T>(this IEnumerable<T> students) where T : Student
        {
            var studentsOrdered = students.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.LastName).ToList();

            return studentsOrdered;
        }

        // Compare strings
        private static int CompareStrings(string strA, string strB)
        {
            
            int equalValue = String.Compare(strA, strB);
            // equalValue < 0 strA is less than strB
            // equalValue == 0 strA equals strB
            // equalValue > 0 strA is greater than strB, and String.Compare returned a value greater than 0

            return equalValue;
        }


        // Sellect students from sellected group
        public static IEnumerable<T> Group<T>(this IEnumerable<T> students, int groupNumber) where T : Student
        {
            var studentsFromGroup = students.Where(st => st.GroupNumber == groupNumber).ToList();
                
            return studentsFromGroup;
        }
        
        // Extract all students that have email in abv.bg.
        // Use string methods and LINQ.
        public static IEnumerable<T> EmailContains<T>(this IEnumerable<T> students, string email) where T : Student
        {
            var studentsWithEmailLike = students.Where(st => st.Email.Contains(email)).ToList();

            return studentsWithEmailLike;
        }

        // Extract all students with phones in Sofia.
        // Use LINQ
        public static IEnumerable<T> PhoneNumberContains<T>(this IEnumerable<T> students, string phonePrefix) where T : Student
        {
            var studentsWithPhonePrefix = students.Where(st => st.Tel.Contains(phonePrefix)).ToList();

            return studentsWithPhonePrefix;
        }

        // Useful ex method that foreach collection for me. Best is can be chained if need.
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (var item in collection)
            {
                action(item);
            }
            return collection;
        }


    }
}
