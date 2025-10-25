using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string years = Console.ReadLine();
            string pattern = @"(?<Day>\d{2})(?<sep>[\.\-\/])(?<Month>[A-Z][a-z]{2})\k<sep>(?<Year>\d{4})";

            foreach (Match match in Regex.Matches(years, pattern))
            {
                int day = int.Parse(match.Groups["Day"].Value);
                string month = match.Groups["Month"].Value;
                int year = int.Parse(match.Groups["Year"].Value);

                Console.WriteLine($"Day: {day:d2}, Month: {month}, Year: {year}");
            }
        }
    }
}
