using RaidGroup.Core;
using RaidGroup.Core.Interfaces;
using RaidGroup.Factory;
using RaidGroup.Factory.Iterfaces;
using RaidGroup.IO;
using RaidGroup.IO.Interfaces;

namespace RaidGroup
{
    public class Program
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            IHeroFactory factory = new HeroFactory();

            IEngine engine = new Engine(reader, writer,factory);
            engine.Run();
        }
    }
}
