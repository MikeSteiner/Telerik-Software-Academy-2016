using System;

using Engine.Contracts;

namespace Engine.InputReader
{
    public class Reader : IReader
    {
        /// <summary>
        /// That particular reader implementateion is reading data from the console as string
        /// </summary>
        /// <returns>string</returns>
        public string ReadText()
        {
            return Console.ReadLine();
        }
    }
}
