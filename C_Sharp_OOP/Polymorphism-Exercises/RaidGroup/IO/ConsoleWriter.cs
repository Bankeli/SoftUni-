using RaidGroup.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidGroup.IO
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string str) => Console.Write(str);



        public void WriteLine(string str) => Console.WriteLine(str);

    }
}
