using InventorySystem.Models;
using InventorySystem.Models.Interfaces;

namespace InventorySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var backpack = new Inventory();
            Weapon sword = new Weapon("Excalibur", 3.5, 25);
            Weapon axe = new Weapon("Battle Axe", 5.0, 30);
            Potion healthPotion = new Potion("Health Potion", 0.5, 50);
            Potion manaPotion = new Potion("Mana Potion", 0.4, 30);

            try
            {
                backpack.AddItem(sword);
                backpack.AddItem(axe);
                backpack.AddItem(healthPotion);
                backpack.AddItem(manaPotion);

                backpack.AddItem(new Weapon("Excalibur", 3.5, 49));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            backpack.PrintAllItems();

            Console.WriteLine( backpack.GetTotalWeight());
        }
    }
}
