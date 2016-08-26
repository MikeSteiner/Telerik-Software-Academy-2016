namespace Cosmetics.Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Cosmetics.Contracts;
    using Cosmetics.Engine;

    class MockedEngine : CosmeticsEngine
    {
        public MockedEngine(
            ICosmeticsFactory factory,
            IShoppingCart shoppingCart,
            ICommandProvider provider)
            :base(factory, shoppingCart, provider)
        {
        }

        public IDictionary<string, ICategory> Categories { get { return this.categories; } }
        public IDictionary<string, IProduct> Products { get { return this.products; } }
    }
}
