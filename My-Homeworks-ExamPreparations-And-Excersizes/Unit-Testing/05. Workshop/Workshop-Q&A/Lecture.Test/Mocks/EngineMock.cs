using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Contracts;
using Engine.Logic;

namespace EngineTest.Mocks
{
    // If we have virtual methods, we can ovverride them
    // Strong coupling => make it virtual

    public class EngineMock : MainEngine
    {
        public EngineMock(IReader reader) : base(reader)
        {
        }

        public string CommadToReturn { get; set; }


        protected override string ReadFromTheFuckingConsole()
        {
            return this.CommadToReturn;
        }
    }
}
