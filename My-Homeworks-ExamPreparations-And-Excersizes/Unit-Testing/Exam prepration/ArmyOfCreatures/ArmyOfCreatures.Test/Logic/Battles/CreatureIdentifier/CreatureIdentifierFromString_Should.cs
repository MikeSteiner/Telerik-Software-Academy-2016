using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArmyOfCreatures.Logic.Battles;

namespace ArmyOfCreatures.Test.Logic
{
    [TestClass]
    public class CreatureIdentifierFromString_Should
    {
        [TestMethod]
        public void ThrowArgumentNullException_WhenCalledWithNullableValueToParseArgument()
        {
            // Arrange
            string nullableString = null;
            
            // Act
            Action actCreatureIdentifierFromString =
                () => CreatureIdentifier.CreatureIdentifierFromString(nullableString);

            // Assert
            Assert.ThrowsException<ArgumentNullException>(actCreatureIdentifierFromString);
        }

        [TestMethod]
        public void ReturNewObjectOfTypeCreateIdentifier_WhenCalledWithValidValueToParseArgument()
        {
            // Arrange
            string valueToParse = "Goblin(1)";

            // Act
            var creature =  CreatureIdentifier.CreatureIdentifierFromString(valueToParse);

            // Assert
            Assert.IsInstanceOfType(creature, typeof(CreatureIdentifier));
        }

        [TestMethod]
        public void CreateCreateIdentifierWithAllProperiesSet_WhenCalledWithValidValueToParseArgument()
        {
            // Arrange
            string valueToParse = "Goblin(1)";
            string expectedCreatureType = "Goblin";
            int expectedArmyNumber = 1;

            // Act
            var creature = CreatureIdentifier.CreatureIdentifierFromString(valueToParse);

            // Assert
            Assert.AreEqual(expectedCreatureType, creature.CreatureType);
            Assert.AreEqual(expectedArmyNumber, creature.ArmyNumber);
        }
    }
}
