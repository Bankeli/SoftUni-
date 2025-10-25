using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            foreach (Match match in Regex.Matches(text, pattern))
            {
                Console.Write(match.Value + " ");
            }
        }
    }
}
