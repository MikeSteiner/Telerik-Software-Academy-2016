using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using WarMachines.Machines;

namespace WarMachines.Test.Machines
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateObjectOfTypePilot_WhenCalledWithValidNameArgument()
        {
            // Arrange
            string pilotName = "Alex";
            Pilot pilotAlex = new Pilot(pilotName);

            // Act and Assert
            Assert.IsInstanceOfType(pilotAlex, typeof(Pilot));

        }

        [TestMethod]
        public void SetCorrectlyAllProperies_WhenCalledWithValidArguments()
        {
            // Arrange
            string expectedPilotName = "Alex";
            Pilot pilotAlex = new Pilot(expectedPilotName);

            // Act
            string realPilotName = pilotAlex.Name;

            // Act and Assert
            Assert.AreEqual(expectedPilotName, realPilotName);

        }
    }
}
