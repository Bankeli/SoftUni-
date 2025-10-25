using System;
using System.Collections.Generic;
using System.Linq;

namespace CocktailBar
{
    public class Cocktail
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public double Volume { get; set; }
        public List<string> Ingredients { get; set; }

        public Cocktail(string name, decimal price, double volume, string ingredients)
        {
            this.Name = name;
            this.Price = price;
            this.Volume = volume;
            this.Ingredients = ingredients
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(i => i.Trim())   
                .ToList();
        }

        public override string ToString()
        {
           
            return $"{this.Name}, Price: {this.Price:F2} BGN, Volume: {this.Volume} ml\n" +
                   $"Ingredients: {string.Join(", ", this.Ingredients)}";
        }
    }
}
