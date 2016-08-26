namespace School.Common
{
    using System;
    using System.Collections.Generic;

    public static class Validator
    {
        public static void IsNameNullOrEmpty(string name)
        {
            string msg = "Name should not be null or empty!";

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(msg);
            }
        }

        public static void IsNull(object obj)
        {
            string msg = "Should not be null!";

            bool isNull = (obj == null);
            if (isNull)
            {
                throw new ArgumentNullException(msg);
            }
        }

        public static void IsIdNumberInRange(int idNumber)
        {
            // Number is between 10000 and 99999.
            string msg = "Number is not between 10000 and 99999";
            
            bool isValid = (idNumber >= 10000 && idNumber <= 99999);
            if (!isValid)
            {
                throw new ArgumentOutOfRangeException(msg);
            }
        }

        public static void IsIdNumberIntegerValue(string idNumber)
        {
            string msg = "Number is not a valid integer value";
            int result;

            bool isValidInt = int.TryParse(idNumber, out result);
            if (!isValidInt)
            {
                throw new ArgumentOutOfRangeException(msg);
            }
        }

        // Unique number.
        public static void IsIdNumerUnique(int idNumber, Dictionary<int, Student> studentsInSchool)
        {
            // Unique number.
            string msg = "Number is not unique, allready exists!";            

            bool isNotUnique = studentsInSchool.ContainsKey(idNumber);
            if (isNotUnique)
            {
                throw new ArgumentOutOfRangeException(msg);
            }

        }

        // Participating students in couset should be less than 30.
        public static void StudentsInCourseLessThanThirty(Course course)
        {
            string msg = "Participating students in couset should be less than 30!";

            bool areStudentsLessThirty = course.ParticipatingStudents.Count < 30;
            if (!areStudentsLessThirty)
            {
                throw new ArgumentException(msg);
            }

        }
    }
}
