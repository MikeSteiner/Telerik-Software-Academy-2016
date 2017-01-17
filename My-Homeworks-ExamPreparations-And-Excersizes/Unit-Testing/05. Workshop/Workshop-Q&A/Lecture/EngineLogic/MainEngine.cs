using System;

using Engine.Contracts;
using Engine.InputReader;

namespace Engine.Logic
{
    public class MainEngine
    {
        public event EventHandler MyExecuteCommandEvent;

        private readonly IReader reader;

        // Event handling
        protected virtual void OnMyExecuteCommandEvent()
        {
            if (this.MyExecuteCommandEvent != null)
            {
                this.MyExecuteCommandEvent(this, new EventArgs());
            }
        }


        // Not a good practice
        // String coupling with the console direct or trough our instance
        // Inversion of control and dependency injection

        public MainEngine(IReader reader)
        {
            this.reader = reader;
        }

        public void ExecuteCommand()
        {
            string commandAsString = ReadFromTheFuckingConsole();
        }

        // private string ReadFromTheFuckingConsole()
        protected virtual string ReadFromTheFuckingConsole()
        {
            // NEW coupling with specific thing 
            var consoleReader = new Reader();
            // return consoleReader.ReadText();
            // return Console.ReadLine();

            // Best practice
            return reader.ReadText();
        }
    }

}
