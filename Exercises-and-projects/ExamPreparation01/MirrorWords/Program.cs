using System.Text.RegularExpressions;

namespace MirrorWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"(\@|\#)(?<word1>[A-Za-z]{3,})\1\1(?<word2>[A-Za-z]{3,})\1";

            MatchCollection matches = Regex.Matches(text, pattern);

            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
               
            }
            else
                Console.WriteLine($"{matches.Count} word pairs found!");

            List<string> mirrorWords = new();

            foreach (Match match in matches)
            {
                string word1 = match.Groups["word1"].Value;
                string word2 = match.Groups["word2"].Value;

                string reversedword = new string(word2.Reverse().ToArray());

                if (word1 == reversedword)
                {
                    mirrorWords.Add($"{word1} <=> {word2}");
                }
            }
            if (mirrorWords.Count == 0)
            {
                Console.WriteLine($"No mirror words!");
                return;
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", mirrorWords));
            }
        }
    }
}
