using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Cosmetics.Engine;
using Cosmetics.Common;
using Cosmetics.Contracts;
using Cosmetics.Products;

namespace Cosmetics.Test.Engine
{
    [TestClass]
    public class CreateShampoo_Should
    {
        [TestMethod]
        public void ReturnNewObjectOfTypeShampoo_WhenCreatedWithValidInputAtributes()
        {
            // Arrange
            string name = "Hair stays";
            string brand = "Nivea";
            decimal price = 10m;
            uint milliliters = 100;
            var cosmeticsFactory = new CosmeticsFactory();

            // Act
            IShampoo shampoo = cosmeticsFactory.CreateShampoo(
                name,
                brand,
                price,
                GenderType.Men,
                milliliters,
                UsageType.EveryDay);

            // Assert
            Assert.IsInstanceOfType(shampoo, typeof(Shampoo));
        }
    }
}
