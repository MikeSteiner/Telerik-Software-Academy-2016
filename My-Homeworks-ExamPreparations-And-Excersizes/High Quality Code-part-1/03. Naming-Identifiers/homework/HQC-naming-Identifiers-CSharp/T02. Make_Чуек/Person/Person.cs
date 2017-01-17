using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonCreator.Common;

namespace PersonCreator
{
    public class Person
    {
        public Person(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public Person(int age)
        {
            this.Age = age;
            if (this.Age % 2 == 0)
            {
                this.Name = "Батката";
                this.Gender = Gender.Male;
            }
            else
            {
                this.Name = "Мацето";
                this.Gender = Gender.Femail;
            }
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public Gender Gender { get; set; }

        public override string ToString()
        {
            string toString = string.Format("Name: {0}; Age: {1}; Gender: {2}", this.Name, this.Age, this.Gender);

            return toString;
        }
    }
}
