namespace School.Contracts
{
    using System;

    public interface IStudent
    {
        string FirstName { get; }

        string LastName { get; }

        int IdNumber { get; }

        string FullName { get; }
    }
}
