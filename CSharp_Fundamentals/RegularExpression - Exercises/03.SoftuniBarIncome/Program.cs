using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace _03.SoftuniBarIncome
{
    internal class Program
    {

        public class Bartender
        {
            public Bartender(string customer, string product,int count, double price)
            {
                Customer = customer;
                Product = product;
                Count = count;
                Price = price;
            }
            public string Customer { get; set; }
            public string Product { get; set; }
            public int Count { get; set; }
            public double Price {  get; set; }

           

        }
        static void Main(string[] args)
        {
            string input = string.Empty;

            string pattern = @"\%([A-Z][a-z]+)\%[^|$%.]*\<(\w+)\>[^|$%.]*\|(\d+)\|[^|$%.]*?(\d+(?:\.\d+)?)\$";
            double totalPrice = 0;

            List<Bartender> orders = new List<Bartender>();

            while ((input = Console.ReadLine()) != "end of shift")
            {
                foreach(Match match in Regex.Matches(input, pattern))
                {
                    string customer = match.Groups[1].Value;
                    string product = match.Groups[2].Value;
                    int count = int.Parse(match.Groups[3].Value);
                    double price = double.Parse(match.Groups[4].Value);

                    Bartender newOrder = new Bartender(customer, product, count, price);

                    orders.Add(newOrder);

                    totalPrice += count * price;

                    Console.WriteLine($"{customer}: {product} - {price*count:f2}");
                }

                
            }
            Console.WriteLine($"Total income: {totalPrice:F2}");
        }
    }
}
