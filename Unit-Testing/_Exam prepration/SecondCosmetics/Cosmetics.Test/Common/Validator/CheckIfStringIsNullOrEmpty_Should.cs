using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Cosmetics.Common;

namespace Cosmetics.Test.Common
{
    [TestClass]
    public class CheckIfStringIsNullOrEmpty_Should
    {
        [TestMethod]
        public void ThroeNullReferenceException_WhenTextArgumentIsNull()
        {
            //Cosmetics.Common.Validator.CheckIfStringIsNullOrEmpty(null);
            //Act and Assert
            Assert.ThrowsException<NullReferenceException>(() => Cosmetics.Common.Validator.CheckIfStringIsNullOrEmpty(null));
        }

        [TestMethod]
        public void ThroeNullReferenceException_WhenTextArgumentIsEmpty()
        {
            // Arrange
            string emptyString = string.Empty;

            //Act and Assert
            Assert.ThrowsException<NullReferenceException>(() => Cosmetics.Common.Validator.CheckIfStringIsNullOrEmpty(emptyString));
        }

        [TestMethod]
        public void NotThroeNullReferenceException_WhenTextArgumentIsNotNullAndNotEmpty()
        {
            // Arrange
            string testString = "abcd";

            // Act
            Validator.CheckIfStringIsNullOrEmpty(testString);

            //Assert
            Assert.IsTrue(true);
        }
    }
}
