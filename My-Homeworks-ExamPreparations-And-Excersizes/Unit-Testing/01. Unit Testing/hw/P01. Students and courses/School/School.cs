/*
 * Task 1. Students and courses

Write three classes: Student, Course and School.

Students should have name and unique number(inside the entire School).
Name can not be empty and the unique number is between 10000 and 99999.
Each course contains a set of students.
Students in a course should be less than 30 and can join and leave courses.

Write VSTT tests
Use 2 class library projects in Visual Studio: School.csproj and School.Tests.csproj
Execute the tests using Visual Studio and check the code coverage.Ensure it is at least 90%.
*/

namespace School
{
    using Common;
    using System.Collections.Generic;
    using System.Text;

    public class School
    {
        private string name;
        private Dictionary<int, Student> students;
        private Dictionary<int, Course> courses;

        public School(string name)
        {
            this.Name = name;
            this.students = new Dictionary<int, Student>();
            this.courses = new Dictionary<int, Course>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                // Validate School name
                Validator.IsNameNullOrEmpty(value);

                this.name = value;
            }
        }

        public void AddStudent(string firstName, string lastName, int idNumber)
        {           
            // TODO validate student ID number is unique
            Validator.IsIdNumerUnique(idNumber, students);            

            Student newStudent = new Student(firstName, lastName, idNumber);
            this.students[idNumber] = newStudent;

        }

        public Student GetStudent(int idNumber)
        {
            return this.students[idNumber];
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this.Name);
            sb.AppendLine(new string('-', 20));

            foreach (KeyValuePair<int, Student> student in this.students)
            {

                sb.Append(student.Key.ToString());
                sb.Append(": ");
                sb.Append(student.Value.ToString());
                sb.AppendLine();
            }
            sb.AppendLine(new string('-', 20));

            foreach (KeyValuePair<int, Course> course in this.courses)
            {
                sb.Append(course.Value.Name);
                foreach (var participaitingStudents in course.Value.ParticipatingStudents)
                {
                    participaitingStudents.ToString();
                    sb.AppendLine();
                }
            }
            sb.AppendLine(new string('-', 20));

            return sb.ToString();
        }
    }
}
