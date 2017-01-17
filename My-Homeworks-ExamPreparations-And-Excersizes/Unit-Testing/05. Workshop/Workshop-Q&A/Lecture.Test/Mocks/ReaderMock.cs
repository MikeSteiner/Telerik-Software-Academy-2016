using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.InputReader;
using Engine.Contracts;

namespace Lecture.Test.Mocks
{
    public class ReaderMock : Reader, IReader
    {
        Reader readerMock = new Reader();
    }
}
