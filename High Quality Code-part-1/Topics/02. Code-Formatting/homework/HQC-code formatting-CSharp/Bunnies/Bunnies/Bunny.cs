namespace BunniesSpace
{
    using System;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Text;

    [Serializable]
    public class Bunny
    {
        public Bunny(string name, int age, FurType furType)
        {
            this.Age = age;
            this.Name = name;
            this.FurType = furType;
        }

        public int Age { get; private set; }

        public string Name { get; private set; }

        public FurType FurType { get; private set; }

        public void Introduce(IWriter writer)
        {
            string stringToWrite = string.Empty;

            stringToWrite = string.Format("{0} - \"I am {1} years old!\"", this.Name, this.Age);
            writer.WriteLine(stringToWrite);
            stringToWrite = string.Format("{0} - \"And I am {1}", this.Name, this.FurType.ToString().SplitToSeparateWordsByUppercaseLetter());
            writer.WriteLine(stringToWrite);
        }

        public override string ToString()
        {
            var builderSize = 200;
            var builder = new StringBuilder(builderSize);

            builder.AppendLine($"Bunny name: {this.Name}");
            builder.AppendLine($"Bunny age: {this.Age}");
            builder.AppendLine($"Bunny fur: {this.FurType.ToString().SplitToSeparateWordsByUppercaseLetter()}");

            return builder.ToString();
        }
    }
}