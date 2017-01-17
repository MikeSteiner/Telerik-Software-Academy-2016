/*
Each course contains a set of students.
Students in a course should be less than 30 and can join and leave courses.
 */
namespace School
{    
    using System;
    using System.Collections.Generic;
    using Common;

    public class Course : ICourse
    {
        private string name;
        private List<Student> participatingStudents;

        public Course(string name)
        {
            this.participatingStudents = new List<Student>();
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                // Name validation here
                Validator.IsNameNullOrEmpty(value);

                this.name = value;
            }
        }

        public List<Student> ParticipatingStudents
        {
            get
            {
                return this.participatingStudents;
            }
        }

        public void AddStudent(Student student)
        {
            // Check participating students count 
            Validator.StudentsInCourseLessThanThirty(this);

            this.participatingStudents.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            this.participatingStudents.Remove(student);
        }
    }
}
