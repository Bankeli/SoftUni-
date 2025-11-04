

using Vehicle.IO.Interfaces;

namespace Vehicle.IO
{
    public class ConsoleReader : IReader
    {
        public string ReadLine() => Console.ReadLine();

    }
}
