using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Models
{
    internal class Inventory 
    {
       public Inventory()
        {
            this.Backpack = new List<Item>();
        }

        public List<Item> Backpack { get; private set; }

       public void AddItem(Item item)
        {
            if (!this.Backpack.Any(i => i.Name == item.Name))
            {
                this.Backpack.Add(item);
                
            }
            else
                throw new ArgumentException($"Item {item.Name} is already added in the backpack");
           
        }

       public void RemoveItem (string itemName)
        {
            var foundedItem = Backpack.FirstOrDefault(i => i.Name == itemName);
            if (foundedItem != null) 
                Backpack.Remove(foundedItem);
        }

        public void PrintAllItems()
        {
            foreach (var item in Backpack)
            {
                Console.WriteLine(item.GetInfo()); 
            }
        }

        public string GetTotalWeight()
        {
            var result = $"Total weight is: {Backpack.Sum(w => w.Weight)} KG";
            return result;
        }
    }
}
