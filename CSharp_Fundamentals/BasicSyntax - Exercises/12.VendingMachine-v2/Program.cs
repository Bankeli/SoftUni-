namespace _12.VendingMachine_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double coinsSum = 0;
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Start")
            {
             double coins = double.Parse(input);

                switch (coins)
                {
                    case 0.1:
                    case 0.2:
                    case 0.5:
                    case 1:
                    case 2:
                        coinsSum += coins;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {coins}");
                        break;
                }
                
            }

            Dictionary<string, double> products = new Dictionary<string, double>
            {
                {"Nuts",2.0},
                {"Water", 0.7},
                {"Crisps", 1.5},
                {"Soda", 0.8},
                {"Coke", 1.0}
            };

            while ((input = Console.ReadLine()) != "End")
            {
                if (!products.ContainsKey(input))
                {
                    Console.WriteLine("Invalid product");
                    continue;
                }

                double price = products[input];

                if (coinsSum >= price)
                {
                    Console.WriteLine($"Purchased {input.ToLower()}");
                    coinsSum -= price;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                    
                }
            }

            Console.WriteLine($"Change: {coinsSum:f2}");
        }
    }
}
