using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Models.Interfaces
{
    internal interface IItem
    {
        string Name { get; }
        double Weight { get; }

        string GetInfo();
    }
}
