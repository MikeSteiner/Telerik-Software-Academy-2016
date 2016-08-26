namespace School.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Tests for the School class
    /// </summary> 
    [TestClass]
    public class SchoolTest
    {
        
        [TestMethod]
        public void School_Name_ShouldNotThrowExceptionWhenCreatedWithValidName()
        {
            var school = new School("48 basic school Iosiph Kovachev");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void School_Name_AddingNullableStringShouldThrowException()
        {
            var school = new School(null);
        }

    }
}
