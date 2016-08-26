/*
Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
Create a List<Student> with sample students. Select only the students that are from group number 2.
Use LINQ query. Order the students by FirstName.
 * 
 */

namespace StudentsTelerikAcademy
{
    using System.Collections.Generic;
    using StudentsTelerikAcademy.Extensions;

    public class Student
    {
        private string firstName;
        private string lastName;
        private long fn;
        private string tel;
        private string email;
        List<int> marks;
        private int groupNumber;
        private int age;

        public Student()
        {
            this.firstName = string.Empty;
            this.lastName = string.Empty;
            this.fn = -1;
            this.tel = string.Empty;
            this.email = string.Empty;
            this.marks = new List<int>();
            this.groupNumber = -1;
        }

        public Student(string firstName, string lastName, long faculcyNumber, string tel, string email, List<int> marks, int groupNumber, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.fn = faculcyNumber;
            this.tel = tel;
            this.email = email;
            this.marks = marks;
            this.groupNumber = groupNumber;
            this.age = age;

        }

        public string FirstName{
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public long FaculcyNumber
        {
            get
            {
                return this.fn;
            }
            set
            {
                this.fn = value;
            }
        }

        public string Tel
        {
            get
            {
                return this.tel;
            }
            set
            {
                this.tel = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        //Marks come here

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            set
            {
                this.groupNumber = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public string FullName
        {
            get
            {
                return this.firstName + " " + this.lastName;
            }            
        }

        public override string ToString()
        {
            return this.firstName + " " +
                this.lastName + " " +
                this.fn + " " +
                this.tel + " " +
                this.email + " " +
                this.groupNumber +
                " Marks:" + string.Join(";", this.marks) + " " +
                "Age:" + this.age;
        }

    }
}
