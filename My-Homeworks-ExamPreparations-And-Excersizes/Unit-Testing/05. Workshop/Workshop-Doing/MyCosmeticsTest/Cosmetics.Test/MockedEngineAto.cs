namespace Cosmetics.Test
{
    using Contracts;
    using Engine;
    using System.Collections.Generic;

    class MockedEngineATo : CosmeticsEngine
    {
        public MockedEngineATo(
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
                return this.categories;
            }
        }

        public IDictionary<string, IProduct> Products
        {
            get
            {
                return this.products;
            }
        }


    }
}
