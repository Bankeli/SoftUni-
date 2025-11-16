using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Models
{
    internal class Potion : Item
    {
        public Potion(string name, double weight, int healingAmount)
            : base(name, weight)
        {
            this.HealingAmount = healingAmount;
        }
        public int HealingAmount { get; private set; }

        public override string GetInfo() => $"Potion: {Name} - Heals: {HealingAmount} HP, Weight: {Weight}kg";
        
    }
}
