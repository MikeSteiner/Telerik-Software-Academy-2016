using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using WarMachines.Engine;
using WarMachines.Interfaces;

namespace WarMachines.Test.Engine
{
    [TestClass]
    public class HirePilot_Should
    {
        [TestMethod]
        public void ReturnObjectOfTypePilot_WhenCreatedWithValidNameArgument()
        {
            // Arrange
            string pilotAlexName = "Alex";
            MachineFactory mashinefctory = new MachineFactory();

            // Act
            IPilot pilotAlex = mashinefctory.HirePilot(pilotAlexName);

            // Assert
            Assert.IsInstanceOfType(pilotAlex, typeof(IPilot));
        }

        [TestMethod]
        public void ThrowArgumentOutOfRangeException_WhenNameArgumentIsEmptyString()
        {
            // Arrange
            string pilotName = string.Empty;
            MachineFactory mashinefctory = new MachineFactory();
            Action<string> actionHirePilot = 
                (string s) => mashinefctory.HirePilot(s);

            // Act and Assert
            // Assert.ThrowsException<ArgumentOutOfRangeException>(() => mashinefctory.HirePilot(pilotName));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => actionHirePilot.Invoke(""));
        }
    }
}
