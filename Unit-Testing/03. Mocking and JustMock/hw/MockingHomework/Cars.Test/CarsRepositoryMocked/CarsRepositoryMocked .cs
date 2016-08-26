namespace Cars.Test.CarsRepositoryMocked
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    using Cars.Contracts;
    using Cars.Models;

    [TestClass]
    public abstract class CarsRepositoryMocked : ICarsRepositoryMocked
    {
        protected CarsRepositoryMocked()
        {
            this.PopulateFakeData();
            this.ArrangeCarsRepositoryMock();
        }

        public ICarsRepository CarsDataRepository { get; protected set; }

        protected ICollection<Car> FakeCarCollection { get; private set; }

        private void PopulateFakeData()
        {
            this.FakeCarCollection = new List<Car>
            {
                new Car { Id= 1, Make = "Honda", Model = "Prelude", Year = 1997 },
                new Car { Id= 2, Make = "Honda", Model = "Accord Type R", Year = 2001 },
                new Car { Id= 3, Make = "Honda", Model = "Civic", Year = 2015 },
                new Car { Id= 4, Make = "Honda", Model = "Legend", Year = 2005 },
                new Car { Id= 5, Make = "BMW", Model = "E36 1.6i", Year = 1993 },
            };
        }

        protected abstract void ArrangeCarsRepositoryMock();
    }
}
