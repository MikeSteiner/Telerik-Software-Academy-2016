using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Cosmetics.Engine;
using Cosmetics.Contracts;
using Cosmetics.Common;

namespace Cosmetics.Test.Products
{
    [TestClass]
    public class Print_Should
    {
        // Shampoo.Print()** should return a string with the shampoo details in the required format.
        [TestMethod]
        public void ReturnStringWithShampooDetailsInTheRequiredFormat()
        {
            // Arrange
            var cosmeticsFactory = new CosmeticsFactory();
            string name = "Hair stays";
            string brand = "Nivea";
            decimal price = 10m;
            uint milliliters = 100;

            string expectedShampooDetails = @"- Nivea - Hair stays:
  * Price: $1000
  * For gender: Men
  * Quantity: 100 ml
  * Usage: EveryDay";

            // Act
            IShampoo shampoo = cosmeticsFactory.CreateShampoo(
                name,
                brand,
                price,
                GenderType.Men,
                milliliters,
                UsageType.EveryDay);
            string shampooDetails = shampoo.Print();

            // Assert
            Assert.AreEqual(expectedShampooDetails, shampooDetails);

        } 
    }
}
