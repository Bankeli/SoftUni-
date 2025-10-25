using System.Text.RegularExpressions;

namespace _01.Furniture
{
    internal class Program
    {
        public class Furniture
        {
            public Furniture(string name, double price, int quantity)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
            }
            public string Name { get; set; }
            public double Price { get; set; }
            public int Quantity { get; set; }
        }
        static void Main(string[] args)
        {
            string input = string.Empty;

            string pattern = @">>(?<furniture>[A-Za-z]+)<<(?<price>\d+|\d+\.\d+)\!(?<quantity>\d+)";

            List<Furniture> furnitures = new List<Furniture>();
            double totalPrice = 0;

            while ((input = Console.ReadLine()) != "Purchase") 
            {
                foreach (Match match in Regex.Matches(input, pattern))
                {
                    string name = match.Groups["furniture"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    Furniture newFurniture =  new Furniture(name, price, quantity);
                    furnitures.Add(newFurniture);
                    totalPrice += price * quantity;
                }
            }
            Console.WriteLine("Bought furniture:");

            foreach (Furniture furniture in furnitures)
            {
                Console.WriteLine(string.Join("",furniture.Name));
            }

            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
