using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ArmyOfCreatures.Extended;
using ArmyOfCreatures.Extended.Creatures;
using ArmyOfCreatures.Logic.Creatures;

namespace ArmyOfCreatures.Test.Extended
{
    [TestClass]
    public class CreateCreature_Should
    {
        [TestMethod]
        public void CreateObjectOfTypeAncientBehemoth_WhenCalledWithNameArgumentAncientBehemoth()
        {
            // Arrange
            string creatureName = "AncientBehemoth";
            ExtendedCreaturesFactory creaturFactory = new ExtendedCreaturesFactory();

            // Act
            var ancientBehemoth = creaturFactory.CreateCreature(creatureName);

            //Assert
            Assert.IsInstanceOfType(ancientBehemoth, typeof(AncientBehemoth));
        }

        [TestMethod]
        public void CreateObjectOfTypeAngel_WhenCalledWithNameArgumentAngel()
        {
            // Arrange
            string creatureName = "Angel";
            ExtendedCreaturesFactory creaturFactory = new ExtendedCreaturesFactory();

            // Act
            var angel = creaturFactory.CreateCreature(creatureName);

            //Assert
            Assert.IsInstanceOfType(angel, typeof(Angel));
        }
    }
}
