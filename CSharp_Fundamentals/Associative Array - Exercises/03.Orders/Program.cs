using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace _03.Orders
{
    internal class Program
    {

        public class Product
        {
            public Product(string name, decimal price, int quantity)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
                
            }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }

           public void Update(decimal price, int quantity)
            {
                Price = price;
                Quantity += quantity;
            }

            public override string ToString()
            {
                return $"{Name} -> {Price * Quantity:F2}";
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string, Product> productsMap = new Dictionary<string, Product>();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "buy")
            {
                string[] arguments = command.Split();

                string productName = arguments[0];
                decimal productPrice = decimal.Parse(arguments[1]);
                int quantity = int.Parse(arguments[2]);

                if (!productsMap.ContainsKey(productName))
                {
                    Product newProduct = new Product(productName, productPrice, quantity);
                    productsMap.Add(productName, newProduct);
                }
                else
                {
                    productsMap[productName].Update(productPrice, quantity);
                }

            }

            foreach (KeyValuePair<string, Product> products in productsMap)
            {
                Console.WriteLine(products.Value.ToString());
            }
        }

        
    }
}
