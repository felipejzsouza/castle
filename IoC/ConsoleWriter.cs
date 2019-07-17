using System;

namespace IoC
{
    public class ConsoleWriter : IWriter
    {
        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
