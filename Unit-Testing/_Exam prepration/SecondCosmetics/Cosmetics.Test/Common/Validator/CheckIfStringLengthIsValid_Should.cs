using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Cosmetics.Common;

namespace Cosmetics.Test.Common
{
    [TestClass]
    public class CheckIfStringLengthIsValid_Should
    {
        private int minLen = 2;
        private int maxLen = 20;

        [TestMethod]
        public void ThroewIndexOutOfRangeException_WhenTextArgumentLengthIsLessThanMinArgument()
        {
            // Arrange
            string testString = "a";

            // Act and Assert
            //Cosmetics.Common.Validator.CheckIfStringLengthIsValid(testString, minLen, maxLen);
            Assert.ThrowsException<IndexOutOfRangeException>(() => Cosmetics.Common.Validator.CheckIfStringLengthIsValid(testString, maxLen, minLen));

        }

        [TestMethod]
        public void ThroewIndexOutOfRangeException_WhenTextArgumentLengthIsMoreThanMaxArgument()
        {
            // Arrange
            string testString = "AbcdeAbcdeAbcdeAbcdeA";

            // Act and Assert
            Assert.ThrowsException<IndexOutOfRangeException>(() => Cosmetics.Common.Validator.CheckIfStringLengthIsValid(testString, maxLen, minLen));

        }

        [TestMethod]
        public void NotThroewIndexOutOfRangeException_WhenTextArgumentLengthIsMoreThanMinAndLessThanMaxArgument()
        {
            // Arrange
            string validString = "AbcdeAbcdeAbcde";

            // Act 
            Validator.CheckIfStringLengthIsValid(validString, maxLen, minLen);

            // Assert
            Assert.IsTrue(true);

        }
    }
}
