using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cosmetics.Contracts;

namespace Cosmetics.Test
{
    internal class MockShoppingCart : IShoppingCart
    {
        public void AddProduct(IProduct product)
        {
            throw new NotImplementedException();
        }

        public bool ContainsProduct(IProduct product)
        {
            throw new NotImplementedException();
        }

        public void RemoveProduct(IProduct product)
        {
            throw new NotImplementedException();
        }

        public decimal TotalPrice()
        {
            throw new NotImplementedException();
        }
    }
}
