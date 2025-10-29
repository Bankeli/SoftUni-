namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
       //private List<Product> bag;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            Bag = new List<Product>();
        }
        public List<Product> Bag { get; set; }
        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty");
                name = value;
            }
        }

        public decimal Money
        {
            get { return money; }
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Money cannot be negative");
                money = value;
            }
        }

        public void BuyProduct(Product product)
        {
            if (product.Cost > Money)
            {
                Console.WriteLine($"{Name} can't afford {product.Name}");
                return;
            }

            Money -= product.Cost;
            Bag.Add(product);
            Console.WriteLine($"{Name} bought {product.Name}");
        }
    }
}
