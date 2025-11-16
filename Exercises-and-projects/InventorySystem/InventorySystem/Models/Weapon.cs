using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Models
{
    internal class Weapon : Item
    {
        public Weapon(string name, double weight, int damage)
            : base(name, weight)
        {
            this.Damage = damage;
        }

        public int Damage { get; private set; }

        public override string GetInfo() => $"Weapon: {Name} - Damage: {Damage}, Weight: {Weight}kg";
        
    }
}
