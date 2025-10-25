using System.Text.RegularExpressions;

namespace AdAstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"(?<sep>[\#\|])(?<food>[A-Za-z ]+)\k<sep>(?<data>\d{2}\/\d{2}\/\d{2})\k<sep>(?<calories>\d+)\k<sep>";

            MatchCollection match = Regex.Matches(text, pattern);

            int totalCalories = 0;

            List<(string food, string date, int calories)> productsData = new();

            foreach (Match matches in match)
            {
                string food = matches.Groups["food"].Value;
                string year = matches.Groups["data"].Value;
                int calories = int.Parse(matches.Groups["calories"].Value);
                productsData.Add((food,year,calories));
                totalCalories += calories;
            }
            Console.WriteLine($"You have food to last you for: { totalCalories / 2000} days!");

            foreach (var item in productsData)
            {
                
                Console.WriteLine($"Item: {item.food}, Best before: {item.date}, Nutrition: {item.calories}");
            }
        }
    }
}
