/*
Students should have name and unique number(inside the entire School).
Name can not be empty and the unique number is between 10000 and 99999. 
 */
namespace School
{
    using System;
    using Contracts;
    using Common;
    using System.Text;

    public class Student : IStudent
    {
        private string firstName;
        private string lastName;
        private string fullName;
        private int idNumber;

        public Student(string firstName, string lastName, int idNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FullName = this.FirstName + " " + this.LastName;

            this.IdNumber = idNumber;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                // FirstName validation here
                Validator.IsNameNullOrEmpty(value);

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                // LastName validation here
                Validator.IsNameNullOrEmpty(value);

                this.lastName = value;
            }
        }

        public string FullName
        {
            get
            {
                return this.fullName;
            }
            private set
            {
                this.fullName = this.FirstName + " " + this.LastName;
            }
        }

        public int IdNumber
        {
            get
            {
                return this.idNumber;
            }
            private set
            {
                // idNumber vallidation here
                Validator.IsIdNumberInRange(value);
                Validator.IsIdNumberIntegerValue(value.ToString());              

                this.idNumber = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.FullName);
            sb.Append(" - ");
            sb.Append(this.IdNumber.ToString());

            return sb.ToString();
        }
    }
}
