namespace School.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Tests for the class Student
    /// </summary>
    [TestClass]
    public class StudentTest
    {
        Student peshoStudent = new Student("Pesho", "Peshov", 12345);

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Student_FirstName_NullableStringShouldThrowExeption()
        {
            Student newStudent = new Student(null, "last name", 10002);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Student_FirstName_EmptyStringShouldThrowExeption()
        {
            Student newStudent = new Student("", "last name", 10002);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Student_LastName_NullableStringShouldThrowExeption()
        {
            Student newStudent = new Student("First name", null, 10002);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Student_LastName_EmptyStringShouldThrowExeption()
        {
            Student newStudent = new Student("First name", "", 10002);
        }

        [TestMethod]
        public void Student_FirstName_IsProperlyInserted()
        {
            string fName = "Pesho";
            Student student = new Student("Pesho", "Peshov", 12345);

            Assert.AreEqual(fName, student.FirstName);
        }

        [TestMethod]
        public void Student_LastName_IsProperlyInserted()
        {
            string lName = "Peshov";
            Student student = new Student("Pesho", "Peshov", 12345);

            Assert.AreEqual(lName, student.LastName);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Student_IdNumber_ShouldThrowExeptionIfLessThanRange()
        {
            Student student = new Student("Pesho", "Peshov", 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Student_IdNumber_ShouldThrowExeptionIfMoreThanRange()
        {
            //Number is not between 10000 and 99999
            Student student = new Student("Pesho", "Peshov", 100000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Student_IdNumber_ShouldThrowExeptionIfEnteredValueIsNotValidInt()
        {
            //Number is not between 10000 and 99999
            Student student = new Student("Pesho", "Peshov", -01000);
        }

        [TestMethod]
        public void Student_FullName_IsProperlyGenerated()
        {
            string fullName = "Pesho Peshov";
            Student student = new Student("Pesho", "Peshov", 12345);

            Assert.AreEqual(fullName, student.FullName);
        }

    }
}
