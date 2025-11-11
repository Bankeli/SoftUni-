using InventorySystem.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Models
{
    internal abstract class Item : IItem
    {
        protected Item(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name { get; private set; }

        public double Weight { get; private set; }

        public virtual string GetInfo() => $"Item: {Name} (Weight: {Weight}kg)";

    }
}
