using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Cosmetics.Engine;
using Cosmetics.Contracts;
using Cosmetics.Products;

namespace Cosmetics.Test.Engine
{
    [TestClass]
    public class CreateCategory_Should
    {
        // CreateCategory** should return a** new Category**, when the passed parameters are all valid.
        [TestMethod]
        public void ReturnObjectOfTypeCategory_WhenCreatedWithValidArguments()
        {
            // Arrange
            var cosmeticsFactory = new CosmeticsFactory();
            string categoryName = "ForMan";

            // Act
            ICategory categoryForMan = cosmeticsFactory.CreateCategory(categoryName);

            // Assert
            Assert.IsInstanceOfType(categoryForMan, typeof(ICategory));
        }

        [TestMethod]
        public void CreateNewCategoryWithTheNamePassedAsArgument_WhenCreatedWithNameArguments()
        {
            // Arrange
            var cosmeticsFactory = new CosmeticsFactory();
            string categoryName = "ForMe";

            // Act
            ICategory categoryForMan = cosmeticsFactory.CreateCategory(categoryName);

            // Assert
            Assert.AreEqual(categoryForMan.Name, categoryName);
        }
    }
}
