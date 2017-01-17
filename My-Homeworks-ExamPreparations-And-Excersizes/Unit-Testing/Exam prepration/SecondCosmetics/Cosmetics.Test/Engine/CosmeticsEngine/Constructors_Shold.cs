using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

using Cosmetics.Engine;
using Cosmetics.Contracts;

namespace Cosmetics.Test.Engine
{
    [TestClass]
    public class Constructors_Shold
    {

        // - **Start** should read, parse and execute**"CreateCategory" command**, 
        // when the passed input string is in the format that represents a CreateCategory command, 
        // which should result in adding the new Category in the list of categories.


        [TestMethod]
        public void CreateOneNewCategoryInTheCatogorysList_WhenPassedWithInputCommandCreateCategoryCommand()
        {
            //var fakeCosmeticFactroy = new MockCosmeticsFactory();
            //var fakeShoppingCard = new MockShoppingCart();
            //var fakeCommandProvider = new MockCommandProvider();

            var mockedCosmeticFactroy = new Mock<ICosmeticsFactory>();
            var mockedShoppingCard = new Mock<IShoppingCart>();
            var mockedCommandProvider = new Mock<ICommandProvider>();

            var mockedCosmeticsEngine = new MockCosmeticsEngine(
                mockedCosmeticFactroy.Object, 
                mockedShoppingCard.Object, 
                mockedCommandProvider.Object);
            //var engine = new MockedEngine(mockedFactory.Object, mockedCart.Object, mockedProvider.Object);

            IList<string> testInputCommands = new List<string>();
            testInputCommands.Add("CreateCategory ForMale");

            // Act
            var commands = new List<ICommand>()
            {
                Command.Parse(testInputCommands[0])
            };            

            mockedCommandProvider.Setup(x => x.ReadCommands()).Returns(commands);
            mockedCosmeticsEngine.Start();

            // Assert
            Assert.AreEqual(1, mockedCosmeticsEngine.Categories.Count);

            ////var commands = new List<ICommand>()
            ////{
            ////    Command.Parse("CreateCategory ForMale")
            ////};

            //mockedProvider.Setup(x => x.ReadCommands()).Returns(commands);

            //engine.Start();

            //Assert.AreEqual(1, engine.Categories.Count);
        }
    }
}
