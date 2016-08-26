namespace School.Console
{
    using System;

    public class StartingPoint
    {
        static void Main(string[] args)
        {
            School basicSchool48 = new School("48 basc school");

            basicSchool48.AddStudent("Alexander", "Toplijski", 10001);
            basicSchool48.AddStudent("Violeta", "Patrova", 10002);
            basicSchool48.AddStudent("Krasen", "Delchev", 10003);

            Console.WriteLine(basicSchool48.ToString());

            Course mathematic = new Course("Mathematic");
            mathematic.AddStudent(basicSchool48.GetStudent(10001));
            mathematic.AddStudent(basicSchool48.GetStudent(10003));

            Course history = new Course("History");
            history.AddStudent(basicSchool48.GetStudent(10002));

        }
    }
}
