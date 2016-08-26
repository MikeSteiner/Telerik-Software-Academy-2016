using Cosmetics.Contracts;
using System.Collections.Generic;

namespace Cosmetics.Engine
{
    internal interface ICommandProvider
    {
        IList<ICommand> ReadCommands();
    }
}