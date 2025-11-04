using Vehicle.Core;
using Vehicle.Core.Interfaces;
using Vehicle.IO;
using Vehicle.IO.Interfaces;

namespace Vehicle
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            IEngine engine = new Engine(reader, writer);
            engine.Run();
        }
    }
}
