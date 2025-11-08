using RaidGroup.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidGroup.IO
{
    public class ConsoleReader : IReader
    {
        public string ReadLine() => Console.ReadLine();

    }
}
