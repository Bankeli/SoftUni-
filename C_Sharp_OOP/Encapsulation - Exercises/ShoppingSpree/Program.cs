namespace ShoppingSpree
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                var peopleInput = Console.ReadLine().Split(";");
                var people = new List<Person>();

                foreach (var personInfo in peopleInput)
                {
                    var tokens = personInfo.Split('=');
                    string name = tokens[0];
                    decimal money = decimal.Parse(tokens[1]);

                    people.Add(new Person(name, money));
                }


                var productInput = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
                var products = new List<Product>();

                foreach (var productInfo in productInput)
                {
                    var tokens = productInfo.Split('=');
                    string name = tokens[0];
                    decimal cost = decimal.Parse(tokens[1]);

                    products.Add(new Product(name, cost));
                }

                string input = string.Empty;

                while ((input = Console.ReadLine()) != "END")
                {
                    string[] tokens = input.Split();
                    string personName = tokens[0];
                    string productName = tokens[1];

                    Person person = people.FirstOrDefault(p => p.Name == personName);
                    Product product = products.FirstOrDefault(p => p.Name == productName);

                    if (product == null || person == null) continue;

                    if (person.Money >= product.Cost)
                    {
                        person.BuyProduct(product);
                    }
                    else
                        Console.WriteLine($"{person.Name} can't afford {product.Name}");

                }

                foreach (var persona in people)
                {
                    string boughtProducts = persona.Bag.Count > 0
                        ? string.Join(", ", persona.Bag.Select(p => p.Name))
                        : "Nothing bought";

                    Console.WriteLine($"{persona.Name} - {boughtProducts}");
                }
            }
			catch (ArgumentException ex)
			{

                Console.WriteLine(ex.Message);
			}
        }
    }
}
