using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Contracts;
using Cosmetics.Engine;

namespace Cosmetics.Test
{
    class MockCommandProvider : ICommandProvider
    {
        public IList<ICommand> ReadCommands()
        {
            throw new NotImplementedException();
        }
    }
}
