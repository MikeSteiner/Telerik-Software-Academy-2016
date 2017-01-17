namespace StudentsTelerikAcademy
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StudentsList
    {
        
        private List<Student> students2016;

        public StudentsList()
        {
            this.students2016 = new List<Student>();
        }

        public void Add(Student student)
        {
            this.students2016.Add(student); 
        }

        public Student this [int index]
        {
            get
            {
                bool isValidIx = ValidateIndex(index);
                if (!isValidIx)
                {
                    throw new IndexOutOfRangeException(string.Format("Index must be between [{0} and {1})", 0, this.students2016.Count));
                }

                return this.students2016[index];
            }
            set
            {
                bool isValidIx = ValidateIndex(index);
                if (!isValidIx)
                {
                    throw new IndexOutOfRangeException(string.Format("Index must be between [{0} and {1})", 0, this.students2016.Count));
                }

                this.students2016.Add(value);
            }
        }

        private bool ValidateIndex(int index)
        {
            bool isValid = (index >= 0 && index < this.students2016.Count);
            if (isValid)
            {
                return true;
            }

            return false;
        }

        public Student[] StudentsFromGroup(int groupNumber)
        {
            Student[] studentsFromSellectedGrp = this.students2016.Where(st => st.GroupNumber == 2).ToArray();

            return studentsFromSellectedGrp;
        }
    }
}
