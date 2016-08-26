using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Engine.Logic;
using Engine.Contracts;
using Lecture.Test.Mocks;
using EngineTest.Mocks;

namespace EngineLogic.Test
{        
    
    [TestClass]
    public class Constructors_Should
    {
        [TestMethod]
        public void ThrowArgumentNullException_WhenReaderArgumentIsNull()
        {
            // Act and Assert
            Assert.ThrowsException<ArgumentNullException>(() => new MainEngine(null));            
        }

        [TestMethod]
        // TODO Is not nessesary, because the default value ot the obj Reade is null 
        public void ThrowArgumentExeption_WhenReaderAgumentIsEmpty()
        {
        }

        [TestMethod]
        public void CreateValidEngineObject_WhenReaderArgumentIsValidReader()
        {
            // Arrange
            IReader fakeCommandReader = new ReaderMock();
            EngineMock fakeEngineMock = new EngineMock(fakeCommandReader);

            // Act and Assert
            Assert.IsInstanceOfType(fakeEngineMock, typeof(MainEngine));                
        }
    }

    
}
