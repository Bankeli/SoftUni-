using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<=\s|^)\+359(?<sep>[\-\ ])2\k<sep>\d{3}\k<sep>\d{4}\b";
;

            string phones = Console.ReadLine();

            var phoneMatches = Regex.Matches(phones, pattern);

            var matchedPhones = phoneMatches.Cast<Match>().Select(p=> p.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
