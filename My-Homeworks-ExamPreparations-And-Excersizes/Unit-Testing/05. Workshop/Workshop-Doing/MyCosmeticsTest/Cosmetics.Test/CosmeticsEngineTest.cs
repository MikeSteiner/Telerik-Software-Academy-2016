namespace Cosmetics.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using Cosmetics.Engine;
    using Contracts;
    using System.IO;
    using System.Collections.Generic;

    [TestClass]
    public class CosmeticsEngineTest
    {

        //Start** should throw **ArgumentNullException**, when the "input" string 
        // of commands is not in the correct format.
        [TestMethod]
        public void Start_ShouldThrowArgumentNullException_WhenInputStrIsNotInTheCorrectFormat()
        {
            Mock<ICosmeticsFactory> mockedFactory = new Mock<ICosmeticsFactory>();
            Mock<IShoppingCart> mockedCard = new Mock<IShoppingCart>();
            Mock<ICommandProvider> mockedPrvider =  new Mock<ICommandProvider>();
            var engineATo = new MockedEngineATo(mockedFactory.Object, mockedCard.Object, mockedProcider.Object);

            string invalidCommandStr = @"CreateCategory____ ForMan";
            var testCommand = Command.Parse(invalidCommandStr);

            List<ICommand> testCommands = new List<ICommand>();
            testCommands.Add(testCommand);

            mockedPrvider.Setup(pr => pr.ReadCommands()).Returns(testCommands);


        }

       //Start** should read, parse and execute**"CreateCategory" command**, 
       //when the passed input string is in the format that represents a CreateCategory command, 
       //which should result in adding the new Category in the list of categories.
       [TestMethod]
        public void Start_ShouldReadParseAndExecuteCreateCategory()
        {
            var mockedFactory = new Mock<ICosmeticsFactory>();
            var mockedCart = new Mock<IShoppingCart>();
            var mockedProvider = new Mock<ICommandProvider>();

            var engine = new MockedEngine(mockedFactory.Object, mockedCart.Object, mockedProvider.Object);

            var str = new StringReader(@"CreateCategory ForMale");

            var commands = new List<ICommand>()
            {
                Command.Parse("CreateCategory ForMale")
            };

            mockedProvider.Setup(x => x.ReadCommands()).Returns(commands);

            engine.Start();

            Assert.AreEqual(1, engine.Categories.Count);

        }

        //Start** should read, parse and execute**"AddToCategory" command**, 
        //when the passed input string is in the format that represents a AddToCategory command, 
        //which should result in adding the selected product in the respective category.

        //Start** should read, parse and execute**"RemoveFromCategory" command**, when the passed input string is in the format that represents a RemoveFromCategory command, which should result in removing the selected product from the respective category.  

        //Start** should read, parse and execute**"ShowCategory" command**, when the passed input string is in the format that represents a ShowCategory command, which should result in calling the Print() method of the respective cateogry.

        //Start** should read, parse and execute**"CreateShampoo" command**, when the passed input string is in the format that represents a CreateShampoo command, which should result in adding the newly created shampoo in the list of products.

        //Start** should read, parse and execute**"CreateToothpaste" command**, when the passed input string is in the format that represents a CreateToothpaste command, which should result in adding the newly created toothpaste in the list of products.    

        //Start** should read, parse and execute**"AddToShoppingCart" command**, when the passed input string is in the format that represents a AddToShoppingCart command, which should result in adding the selected product to the shopping cart.  

        //Start** should read, parse and execute**"RemoveFromShoppingCart" command**, when the passed input string is in the format that represents a RemoveFromShoppingCart command, which should result in removing the selected product from the shopping cart.

    }
}
