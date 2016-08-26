namespace School
{
    using System.Collections.Generic;

    public interface ICourse
    {
        string Name { get; }

        List<Student> ParticipatingStudents { get; }

        void AddStudent(Student student);
    }
}
