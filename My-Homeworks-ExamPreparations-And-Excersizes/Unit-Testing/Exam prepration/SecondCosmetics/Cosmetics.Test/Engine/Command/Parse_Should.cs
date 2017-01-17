using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Cosmetics.Engine;

namespace Cosmetics.Test.Engine
{
    [TestClass]
    public class Parse_Should
    {

        [TestMethod]
        public void ReturnNewCommandObject_WhenTheInputArgumentIsInValidFormat()
        {
            // Arrange
            Command command = Command.Parse("CreateCategory ForMale");

            // Act and Assert
            Assert.IsInstanceOfType(command, typeof(Command));
        }

        [TestMethod]
        public void AssignCorrectValueToTheCommandPropertyName_WhenTheInputArgumentIsInValidFormat()
        {
            // Arrange
            Command command = Command.Parse("CreateCategory ForMale");
            string expectedNameProperty = "CreateCategory";

            // Act and Assert
            Assert.AreEqual(expectedNameProperty, command.Name);
        }

        [TestMethod]
        public void AssignOneCorrectValueToTheCommandPropertyParameters_WhenTheInputArgumentIsInValidFormat()
        {
            // Arrange
            Command command = Command.Parse("CreateCategory ForMale");
            IList<string> expectedParameters = new string[] { "ForMale" }; 

            // Act and Assert
            Assert.AreEqual(expectedParameters[0], command.Parameters[0]);
        }

        [TestMethod]
        public void AssignFiveCorrectValuesToTheCommandPropertyParameters_WhenTheInputArgumentIsInValidFormat()
        {
            // Arrange
            Command command = Command.Parse("CreateCategory val1 val2 val3 val4 val5");
            IList<string> expectedParameters = new string[] { "val1", "val2", "val3", "val4", "val5" };

            // Act and Assert
            for (int i = 0; i < command.Parameters.Count; i++)
            {
                string expectedValue = expectedParameters[i];
                string realValue = command.Parameters[i];
                Assert.AreEqual(expectedValue, realValue);
            }
        }


        //- **Parse** should throw **ArgumentNullException** with a message that contains the string "Name", 
        // when the "input" string that represents the Command Name is Null Or Empty.
        [TestMethod]
        public void ThrowNullReferenceException_WhenTheWholeInputArgumentIsNull()
        {            
            // Act and Assert
            Assert.ThrowsException<NullReferenceException>(() => Command.Parse(null));
        }

        [TestMethod]
        public void ThrowArgumentNullException_WhenTheWholeInputArgumentIsEmptyString()
        {
            // Arrange
            string emptyString = string.Empty;

            // Act and Assert
            Assert.ThrowsException<ArgumentNullException>(() => Command.Parse(emptyString));
        }

        [TestMethod]
        public void ThrowArgumentNullException_WhenTheInputArgumentContainsWhiteSpaces()
        {
            // Arrange
            string whiteSpacesString = "  ";

            // Act and Assert
            Assert.ThrowsException<ArgumentNullException>(() => Command.Parse(whiteSpacesString));
        }

        [TestMethod]
        public void ThrowArgumentNullException_WhenTheNamePropertyPartFromTheInputArgumentIsEmpty()
        {
            // Arrange
            //Command command = Command.Parse("  ForMale");

            // Act and Assert
            Assert.ThrowsException<ArgumentNullException>(() => Command.Parse("  ForMale"));
        }

        [TestMethod]
        public void ThrowArgumentNullException_WhenThePropertiesPartFromTheInputArgumentIsEmptyMissing()
        {           
            // Act and Assert
            Assert.ThrowsException<ArgumentNullException>(() => Command.Parse("CreateCategory  "));
        }        

    }
}
