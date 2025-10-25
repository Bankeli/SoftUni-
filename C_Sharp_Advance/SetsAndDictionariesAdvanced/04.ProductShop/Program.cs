namespace _04.ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            Dictionary<string, Dictionary<string, double>> shopMap = new();

            while ((input = Console.ReadLine()) != "Revision")
            {
                string[]data = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shop = data[0];
                string product = data[1];
                double price = double.Parse(data[2]);

                if (!shopMap.ContainsKey(shop))
                {
                    shopMap[shop] = new Dictionary<string, double>();
                }
                shopMap[shop][product] = price;
            }

            shopMap = shopMap.OrderBy(s => s.Key).ToDictionary(s => s.Key, s => s.Value);

            foreach (var (shop, products) in shopMap)
            {
                Console.WriteLine($"{shop}->");

                foreach (var (product, price) in products)
                {
                    Console.WriteLine($"Product: {product}, Price: {price}");
                }
            }
        }
    }
}
