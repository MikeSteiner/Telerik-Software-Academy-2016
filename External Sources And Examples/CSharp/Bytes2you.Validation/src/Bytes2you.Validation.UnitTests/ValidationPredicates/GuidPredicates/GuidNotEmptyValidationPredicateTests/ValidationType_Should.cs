﻿using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.GuidPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.GuidPredicates.GuidNotEmptyValidationPredicateTests
{
    [TestClass]
    public class ValidationType_Should
    {
        [TestMethod]
        public void ReturnDefaultValidationType()
        {
            // Arrange.
            IValidationPredicate validationPredicate = GuidNotEmptyValidationPredicate.Instance;

            // Assert.
            Assert.AreEqual(ValidationType.Default, validationPredicate.ValidationType);
        }
    }
}