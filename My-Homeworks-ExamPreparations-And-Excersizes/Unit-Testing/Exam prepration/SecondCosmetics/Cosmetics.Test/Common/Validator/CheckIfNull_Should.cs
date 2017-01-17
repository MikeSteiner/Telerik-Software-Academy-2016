using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Cosmetics.Common;


namespace Cosmetics.Test.Common
{
    [TestClass]
    public class CheckIfNull_Should
    {
        [TestMethod]
        public void ThrowNullReferenceException_WhenCalledWithNullableObject()
        {
            // Act and Assert
            Assert.ThrowsException<NullReferenceException>(() => Cosmetics.Common.Validator.CheckIfNull(null));            
        }

        [TestMethod]
        public void NotThrowNullReferenceException_WhenCalledWithNotNullableObject()
        {
            // Arrange
            Object notNullableObject = new Object();
            GlobalErrorMessages globErrMsg = new GlobalErrorMessages();

            // Act
            Validator.CheckIfNull(globErrMsg);

            // Assert
            Assert.IsTrue(true);
        }

    }
}
