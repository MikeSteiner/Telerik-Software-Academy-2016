
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Engine.InputReader;
using Engine.Contracts;
using Lecture.Test.Mocks;
using EngineTest.Mocks;
using Engine.Logic;

namespace EngineLogic.Test
{
    [TestClass]
    public class ExecuteCommand_Should
    {
        [TestMethod]
        public void ReturString()
        {
            // Arrange
            IReader fakeCommandReader = new ReaderMock();
            //EngineMock fakeEngineMock = new EngineMock(fakeCommandReader);
            fakeCommandReader.
            MainEngine MainEngine = new MainEngine(fakeCommandReader);

            string expectedCommand = "Create Category";

            // Act
            MainEngine.ExecuteCommand();

            // Assert

        }
    }
}
