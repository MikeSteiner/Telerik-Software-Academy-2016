using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cosmetics.Common;
using Cosmetics.Contracts;
using Cosmetics.Products;

namespace Cosmetics.Test
{
    internal class MockCosmeticsFactory : ICosmeticsFactory
    {
        public ICategory CreateCategory(string name)
        {
            
            throw new NotImplementedException();
        }

        public IShampoo CreateShampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
        {
            throw new NotImplementedException();
        }

        public IShoppingCart CreateShoppingCart()
        {
            throw new NotImplementedException();
        }

        public IToothpaste CreateToothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
        {
            throw new NotImplementedException();
        }
    }
}
