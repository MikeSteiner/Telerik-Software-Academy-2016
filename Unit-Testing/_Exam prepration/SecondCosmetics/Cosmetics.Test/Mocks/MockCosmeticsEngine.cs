using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Contracts;
using Cosmetics.Engine;

namespace Cosmetics.Test
{
    class MockCosmeticsEngine : CosmeticsEngine
    {
        public MockCosmeticsEngine(
            ICosmeticsFactory factory, 
            IShoppingCart shoppingCart, 
            ICommandProvider provider) 
            : base(factory, shoppingCart, provider)
        {
        }

        public IDictionary<string, ICategory> Categories
        {
            get
            {
                return base.categories;
            }
        }

        public IDictionary<string, IProduct> Products
        {
            get
            {
                return base.products;
            }
        }
        
    }
}
