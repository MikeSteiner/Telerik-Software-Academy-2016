namespace StudentsTelerikAcademy
{
    /// <summary>
    /// Test class of groups (students groups) for LINQ testing
    /// </summary>
    /// 

    // Create a class Group with properties GroupNumber and DepartmentName.
    // Introduce a property GroupNumber in the Student class.
    // Extract all students from "Mathematics" department.
    // Use the Join operator.

    public class Group
    {
        public Group(int groupNumber, string groupName)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = groupName;
        }

        public int GroupNumber { get; set; }

        public string DepartmentName { get; set; }
    }
}