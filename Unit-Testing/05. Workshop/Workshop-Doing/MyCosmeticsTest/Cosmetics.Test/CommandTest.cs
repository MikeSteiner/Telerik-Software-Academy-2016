namespace Cosmetics.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Cosmetics.Engine;
    using Moq;
    using Contracts;
    using System.Collections.Generic;
    using System.Linq;

    [TestClass]
    public class CommandTest
    {
        //- **Parse** should **return new Command**, when the "input" string is in the required valid format.
        [TestMethod]
        public void Parse_ShouldReturnNewCommandWhenTheInputStringIsInTheRequiredValidFormat()
        {
            // Arrange
            string commandInputString = "CreateShampoo Cool Nivea 0.50 men 500 everyday";
            Command cmd = Command.Parse(commandInputString);                      

            // Act and Assert
            Assert.IsInstanceOfType(cmd, typeof(Command));

            // Assert
        }

        //- **Parse** should set correct values to the newly returned Command object's Properties ("Name" & "Parameters"), when the "input" string is in the valid required format.  
        [TestMethod]
        public void Parse_ShouldSetCorrectValuesToTheNewlyReturnedCommandObjectProp()
        {
            // Arrange
            string commandInputString = "CreateShampoo Cool Nivea 0.50 men 500 everyday";
            string commandName = "CreateShampoo";
            IList<string> commandParameters= "Cool Nivea 0.50 men 500 everyday".Split(' ').ToList();

            Command cmd = Command.Parse(commandInputString);

            // Act and Assert
            Assert.AreEqual(commandName, cmd.Name);
            Assert.AreEqual(string.Join(" ", commandParameters), string.Join(" ", cmd.Parameters));

            //// Assert
        }

        //- **Parse** should throw **ArgumentNullException** with a message that contains the string "Name", when the "input" string that represents the Command Name is Null Or Empty.
        [TestMethod]
        public void Parse_ShouldThrowArgumentNullExceptionWithCommandStringNameIsEmpty()
        {
            // Arrange
            string commandInputString = "   Cool Nivea 0.50 men 500 everyday";
            //Command command = Command.Parse(commandInputString);

            // Act and Assert
            Assert.ThrowsException<ArgumentNullException>(() => Command.Parse(commandInputString));

            //// Assert
        }

        //- **Parse** should throw **ArgumentNullException** with a message that contains the string "Name", when the "input" string that represents the Command Name is Null Or Empty.
        [TestMethod]
        public void Parse_ShouldThrowNullReferenceExceptionWithCommandStringNameIsNull()
        {
            // Arrange
            string commandInputString = null;
            //Command cmd = Command.Parse(commandInputString);

            // Act and Assert
            Assert.ThrowsException<NullReferenceException>(() => Command.Parse(commandInputString));

            //// Assert
        }

        //- **Parse** should throw **ArgumentNullException** with a message that contains the string "List", when the "input" string that represents the Command Parameters is Null or Empty.
        // TODO
    }
}
