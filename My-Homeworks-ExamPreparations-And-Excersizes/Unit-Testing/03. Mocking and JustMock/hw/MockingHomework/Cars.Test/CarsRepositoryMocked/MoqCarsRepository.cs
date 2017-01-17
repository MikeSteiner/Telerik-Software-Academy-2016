namespace Cars.Test.CarsRepositoryMocked
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    using Contracts;
    using Models;
    using System.Linq;

    public class MoqCarsRepository : CarsRepositoryMocked, ICarsRepositoryMocked
    {
        protected override void ArrangeCarsRepositoryMock()
        {
            var mockedCarsRepository = new Mock<ICarsRepository>();
            mockedCarsRepository.Setup(r => r.Add(It.IsAny<Car>())).Verifiable();
            mockedCarsRepository.Setup(r => r.All()).Returns(this.FakeCarCollection);
            mockedCarsRepository.Setup(r => r.Search(It.IsAny<string>())).Returns(this.FakeCarCollection.Where(fCarsColl => fCarsColl.Make == "BMW").ToList());
            // mockedCarsRepository.Setup(r => r.GetById(It.IsAny<int>())).Returns((Car)this.FakeCarCollection.First());
            mockedCarsRepository.Setup(r => r.GetById(It.IsAny<int>())).Returns(this.FakeCarCollection.FirstOrDefault(car => car.Id == 6));

            this.CarsDataRepository = mockedCarsRepository.Object;
        }
    }
}
