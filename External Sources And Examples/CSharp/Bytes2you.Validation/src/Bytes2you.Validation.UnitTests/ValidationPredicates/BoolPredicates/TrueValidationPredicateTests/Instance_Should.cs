﻿using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.BoolPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.BoolPredicates.TrueValidationPredicateTests
{
    [TestClass]
    public class Instance_Should
    {
        [TestMethod]
        public void ReturnNotNull()
        {
            // Assert.
            Assert.IsNotNull(TrueValidationPredicate.Instance);
        }

        [TestMethod]
        public void ReturnOneAndTheSameInstance()
        {
            // Assert.
            for (int i = 0; i < 5; i++)
            {
                Assert.AreSame(TrueValidationPredicate.Instance, TrueValidationPredicate.Instance);
            }
        }
    }
}