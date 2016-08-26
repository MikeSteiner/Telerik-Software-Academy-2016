namespace Cosmetics.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Common;

    //Class - Cosmetics.Common.Validator
    [TestClass]
    public class ValidatorTest
    {        
        //- **CheckIfNull** should throw **NullReferenceException**, when the parameter**"obj"** is null.  
        [TestMethod]
        public void CheckIfNull_ShouldThrowNullReferenceExceptionWhenCreatedWithNullableObject()
        {
            // Arrange
            string msg = "Object is null test!";
            //Validator.CheckIfNull(null, msg);

            // Act and Assert
            Assert.ThrowsException<NullReferenceException>(() => Validator.CheckIfNull(null, msg));

            //// Assert

        }

        //- **CheckIfNull** should **NOT throw** any Exceptions, when the parameter **"obj"** is NOT null.  
        [TestMethod]
        public void CheckIfNull_ShouldNOTThrowAnyExceptionsWhenTheParameterObjIsNOTNull()
        {
            // Arrange
            string msg = "Object is null test!";
            object obj = new object();

            // Act 
            Validator.CheckIfNull(obj, msg);

            // Assert
            Assert.IsTrue(true);
        }
        
        //- **CheckIfStringIsNullOrEmpty** should throw **NullReferenceException**, when the parameter**"text"** is null or empty.
        [TestMethod]
        public void CheckIfStringIsNullOrEmpty_ShouldThrowNullReferenceException_WhenTheParameterTextIsNullOrEmpty()
        {
            // Arrange
            string msg = "";
            string nullString = null;
            string emptyString = string.Empty;

            // Act and Assert
            msg = "Test-string is null!";
            Assert.ThrowsException<NullReferenceException>(() => Validator.CheckIfStringIsNullOrEmpty(nullString), msg);
            msg = "Test-string is empty!";
            Assert.ThrowsException<NullReferenceException>(() => Validator.CheckIfStringIsNullOrEmpty(emptyString), msg);

            //// Assert
        }

        //- **CheckIfStringIsNullOrEmpty** should **NOT throw** any Exceptions, when the parameter**"text"** is NOT null or empty.  
        [TestMethod]
        public void CheckIfStringIsNullOrEmpty_ShouldNOTThrowAnyExceptionsWhenTheParameterTextIsNOTNullOrEmpty()
        {
            // Arrange
            string notNullOrEmptyString = "Not null or empty string";

            // Act and Assert
            Validator.CheckIfStringIsNullOrEmpty(notNullOrEmptyString);

            // Assert
            Assert.IsTrue(true);
        }

        //- **CheckIfStringLengthIsValid** should throw **IndexOutOfRangeException**, when the length of the parameter **"text"** is lower than the minimum allowed value or greater than the maximum allowed value.
        [TestMethod]
        public void CheckIfStringLengthIsValid_ShouldThrowIndexOutOfRangeExceptionWhenTheLengthOfParameterTextIsLowerThanMinimumAllowedValueOrGreaterThanMaximumAllowedValue()
        {
            // Arrange
            int minLen = 2;
            int maxLen = 20;
            string lessThanMinString = "a";
            string moreThanMaxString = "ababababababababababababA";

            // Act and Assert
            Assert.ThrowsException<IndexOutOfRangeException>(() => Validator.CheckIfStringLengthIsValid(lessThanMinString, maxLen, minLen));
            Assert.ThrowsException<IndexOutOfRangeException>(() => Validator.CheckIfStringLengthIsValid(moreThanMaxString, maxLen, minLen));

            //// Assert
        }


        //- **CheckIfStringLengthIsValid** should **NOT throw** any Exceptions, when the length of the parameter "text" is in the allowed boundaries.
        [TestMethod]
        public void CheckIfStringLengthIsValid_ShouldNOTThrowAnyExceptionsWhenTheLengthOfPrameterTextIsInTheAllowedBoundaries()
        {
            // Arrange
            int minLen = 2;
            int maxLen = 20;
            string inTheBounderiesString = "ababab";

            // Act
            Validator.CheckIfStringLengthIsValid(inTheBounderiesString, maxLen, minLen);

            // Assert
            Assert.IsTrue(true);
        }

    }
}
