/*
Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
Create a List<Student> with sample students. Select only the students that are from group number 2.
Use LINQ query. Order the students by FirstName.
 * 
 */

namespace StartingPointNs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using StudentsTelerikAcademy;
    using StudentsTelerikAcademy.Extensions;
    using StudentsTelerikAcademy.Tests;

    public class StartingPoint
    {
        public static void Main(string[] args)
        {
            // Create sample students            
            Student[] students2016 = Test.CreateSampleStudents();

            // ----------------------------------------------------------------------------------------
            // Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
            // Use LINQ query operators.
            Student[] studentsFirstIsBeforeLast = students2016.FirstNameBoforeLast().ToArray();
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Sellected students with first name before the last name");
            foreach (Student student in studentsFirstIsBeforeLast)
            {
                Console.WriteLine(student.ToString());
            }

            // ----------------------------------------------------------------------------------------
            // Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
            Student[] studentsBetween18yAnd24y = students2016.Where(st => (st.Age >= 18) && (st.Age <= 24)).ToArray();
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Sellected students with age between 18 and 24");
            foreach (Student student in studentsBetween18yAnd24y)
            {
                Console.WriteLine(student.ToString());
            }

            // ----------------------------------------------------------------------------------------
            // Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by 
            // first name and last name in descending order.
            // Rewrite the same with LINQ.
            Student[] studentOrdered = students2016.OrderedDesc().ToArray();
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Order students by first name and then by last name");
            foreach (Student student in studentOrdered)
            {
                Console.WriteLine(student.ToString());
            }



            // ----------------------------------------------------------------------------------------
            // Task Add the sample students and sellect those from group two
            Student[] groupTwoStudent = students2016.Where(st => st.GroupNumber == 2).ToArray();

            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Sellected students from group two");
            foreach (Student student in groupTwoStudent)
            {
                Console.WriteLine(student.ToString());
            }

            // ----------------------------------------------------------------------------------------
            // Implement the previous using the same query expressed with extension methods.            
            // Put the group you want to sellect here
            int sellectedGroup = 2;
            Student[] groupTwoStudentExt = students2016.Group(sellectedGroup).ToArray();
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Sellected students from group two with extension method");
            foreach (Student student in groupTwoStudentExt)
            {
                Console.WriteLine(student.ToString());
            }
            // ----------------------------------------------------------------------------------------
            // Extract all students that have email in abv.bg.
            // Use string methods and LINQ.
            string sellectedEmail = "abv.bg";
            Student[] sellectedByEmail = students2016.EmailContains(sellectedEmail).ToArray();
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Sellected students with email in 'abv.bg'");
            foreach (Student student in sellectedByEmail)
            {
                Console.WriteLine(student.ToString());
            }
            // ----------------------------------------------------------------------------------------
            // Extract all students with phones in Sofia.
            // Use LINQ
            string phonePrefix = "3592";
            Student[] sellectedByPhone = students2016.PhoneNumberContains(phonePrefix).ToArray();
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Sellected students with phone in Sofia (fixed network)");
            foreach (Student student in sellectedByPhone)
            {
                Console.WriteLine(student.ToString());
            }

            // ----------------------------------------------------------------------------------------
            // Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
            // Use LINQ.


            // ----------------------------------------------------------------------------------------
            // Create a class Group with properties GroupNumber and DepartmentName.
            // Introduce a property GroupNumber in the Student class.
            // Extract all students from "Mathematics" department.
            // Use the Join operator.


            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Extracted students from \"Mathematics\" department");

            var groups = Test.GroupsGenerator();

            // join groups and students by their GroupNumbers
            students2016
                 .Join(groups,
                     st => st.GroupNumber,
                     gr => gr.GroupNumber,
                     (st, gr) => new { st.FullName, gr.DepartmentName })
                 .Where(x => x.DepartmentName == "Mathematics")
                 .ForEach(x => Console.WriteLine($"{x.DepartmentName} {x.FullName}"));

            // ----------------------------------------------------------------------------------------
            // Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
            // Use LINQ.
             sellectedGroup = 2;
            Student[] studentsByGroup = students2016.Group(sellectedGroup).ToArray();
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Sellected students from group two with extension method");
            foreach (Student student in studentsByGroup)
            {
                Console.WriteLine(student.ToString());
            }


            // ----------------------------------------------------------------------------------------



        }
    }
}
