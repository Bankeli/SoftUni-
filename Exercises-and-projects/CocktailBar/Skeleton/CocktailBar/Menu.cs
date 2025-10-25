using System;
using System.Collections.Generic;
using System.Linq;

namespace CocktailBar
{
    public class Menu
    {
        public Menu(int barCapacity)
        {
            this.BarCapacity = barCapacity;
            this.Cocktails = new List<Cocktail>();
        }

        public int BarCapacity { get; set; }
        public List<Cocktail> Cocktails { get; set; }

        public void AddCocktail(Cocktail cocktail)
        {
            if (this.Cocktails.Count >= this.BarCapacity) return;
            if (this.Cocktails.Any(c => c.Name == cocktail.Name)) return;

            this.Cocktails.Add(cocktail);
        }

        public bool RemoveCocktail(string name)
        {
            Cocktail cocktail = this.Cocktails.FirstOrDefault(c => c.Name == name);
            if (cocktail != null)
            {
                this.Cocktails.Remove(cocktail);
                return true;
            }
            return false;
        }

        public Cocktail GetMostDiverse()
        {
            return this.Cocktails
                .OrderByDescending(c => c.Ingredients.Count)
                .First();
        }

        public string Details(string cocktailName)
        {
            Cocktail cocktail = this.Cocktails.FirstOrDefault(c => c.Name == cocktailName);
            return cocktail != null ? cocktail.ToString() : string.Empty;
        }

        public string GetAll()
        {
            
            return "All Cocktails:\n" +
                   string.Join("\n", this.Cocktails
                       .OrderBy(c => c.Name)
                       .Select(c => c.Name));
        }
    }
}
