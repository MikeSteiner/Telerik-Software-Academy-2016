namespace StudentsTelerikAcademy.Tests
{
    using System;
    using System.Collections.Generic;

    public static class Test
    {

        public static Student[] CreateSampleStudents()
        {
            // Four sample students
            Student goshoStudent = new Student(
                "Gosho", "Goshov", 1234, "0893000001", "gosho@gmail.com", new List<int> { 2, 3, 5 }, 1, 17
                );

            Student peshoStudent = new Student(
               "Pesho", "Peshov", 4321, "0893000002", "pesho@gmail.com", new List<int> { 4, 5, 5 }, 1, 19
               );

            Student sashoStudent = new Student(
               "Sasho", "Sashov", 2143, "+35928323232", "sasho@abv.bg", new List<int> { 2, 6, 3 }, 2, 36
               );

            Student ladyGagaStudent = new Student(
               "Lady", "Gagova", 2143, "0893000004", "lady.gaga@gmail.com", new List<int> { 6, 6, 6 }, 2, 22
               );

            Student[] sampleStudents = new Student[4];
            sampleStudents[0] = goshoStudent;
            sampleStudents[1] = peshoStudent;
            sampleStudents[2] = sashoStudent;
            sampleStudents[3] = ladyGagaStudent;

            return sampleStudents;
        }


        public static Group[] GroupsGenerator()
        {
            var result = new Group[5];
            result[0] = new Group(1, "Programming");
            result[1] = new Group(2, "Mathematics");
            result[2] = new Group(3, "Physics");
            result[3] = new Group(4, "Philosophy");
            result[4] = new Group(5, "Biology");

            return result;
        }



    }
}
