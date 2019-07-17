namespace IoC
{
    public class Composition : IComposition
    {
        readonly IWriter consoleWriter;

        public Composition(IWriter consoleWriter)
        {
            this.consoleWriter = consoleWriter;
            consoleWriter.LogMessage("Log através de construtor");
        }

        public void LogMessage(string message)
        {
            consoleWriter.LogMessage(message);
        }
    }
}
