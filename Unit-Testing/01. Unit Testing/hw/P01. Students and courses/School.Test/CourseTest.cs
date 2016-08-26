namespace School.Test
{    
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [TestClass]
    public class CourseTest
    {
        private const int Thirty = 30;

        Course mathematic = new Course("Mathematic");
        Course history = new Course("History");

        Student alex = new Student("Alexander", "Toplijski", 10001);
        Student violeta = new Student("Violeta", "Patrova", 10002);
        Student krasen = new Student("Krasen", "Delchev", 10003);

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Course_Name_CreatingCourseWithNullableStringShouldThrowException()
        {
            Course mathTest = new Course(null);
        }

        [TestMethod]
        public void Course_Name_ShouldBeSuccesfullyCreatedWithValidName()
        {
            var school = new School("Sport");
        }

        [TestMethod]
        public void Course_AddStudent_ShouldAddStudentToTheCourse()
        {
            mathematic.AddStudent(alex);

            var alexFromCourse = mathematic
                .ParticipatingStudents.Find(std => std.IdNumber == alex.IdNumber);

            Assert.AreEqual(alexFromCourse, alex);
        }

        [TestMethod]
        public void Course_RemoveStudent_ShouldRemoveStudentfromTheCourse()
        {
            mathematic.AddStudent(alex);
            mathematic.RemoveStudent(alex);

            Assert.IsTrue(mathematic.ParticipatingStudents.Count==0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Course_AddStudent_ShouldThrowExeptionWhenStidentsAreMoreThanThirty()
        {
            //mathematic.AddStudent(alex);
            int idNumOffset = 10001;

            for (int i = idNumOffset; i <= idNumOffset + Thirty; i++)
            {
                Student newStd = new Student("Alexander", "Toplijski", i);
                mathematic.AddStudent(newStd);
            }
            
        }
    }
}
