namespace Cars.Controller.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Contracts;
    using Controllers;
    using Cars.Test.CarsRepositoryMocked;
    using System.Collections.Generic;
    using Models;

    [TestClass]
    public class CarsControllerTest
    {
        private readonly ICarsRepository carsData;
        private CarsController controller;

        public CarsControllerTest() : this(new MoqCarsRepository())
        {
        }

        private CarsControllerTest(ICarsRepositoryMocked carsDataMock)
        {
            this.carsData = carsDataMock.CarsDataRepository;
        }

        [TestInitialize]
        public void CreateCarsController()
        {
            this.controller = new CarsController(this.carsData);
        }

        [TestMethod]
        public void IndexShouldReturnAllCars()
        {
            // Arrange
            var model = (ICollection<Car>)this.carsData.All();

            // Act
            // Assert
            Assert.AreEqual(5, model.Count);
        }

        [TestMethod]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarMakeIsNull()
        {
            // Arrange 

            // Act
            // this.controller.Add(null);

            // Assert
            Assert.ThrowsException<ArgumentNullException>(() => this.controller.Add(null));
        }

        [TestMethod]
        public void AddingCarShouldReturnADetail()
        {
            // Arrange
            var car = new Car
            {
                Id = 6,
                Make = "Audi",
                Model = "RS4",
                Year = 2014
            };

            // Act
            this.carsData.Add(car);
            Car audiRS4Car = this.carsData.GetById(6);

            // Assert
            Assert.AreEqual(car.Id, audiRS4Car.Id);
            Assert.AreEqual(car.Make, audiRS4Car.Make);
            Assert.AreEqual(car.Model, audiRS4Car.Model);
            Assert.AreEqual(car.Year, audiRS4Car.Year);
        }

    }
}
