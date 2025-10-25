using System.Text.RegularExpressions;

namespace EmojiDetector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"(?<prefix>\*\*|\:\:)(?<emoji>[A-Z][a-z]{2,})\k<prefix>";
            string tresholdPattern = @"\d";
            ulong coolTreshold = 1;

            foreach (Match match in Regex.Matches(text, tresholdPattern))
            {
                coolTreshold *= ulong.Parse(match.Value);
            }

            Console.WriteLine($"Cool threshold: {coolTreshold}");
            List<string> foundEmojie = new();
            List<string> coolEmojie = new();
            
            foreach (Match match in Regex.Matches(text, pattern))
            {
                foundEmojie.Add(match.Value);

                 string foundEmoji = match.Groups["emoji"].Value;

                uint emojiSum = 0;

                foreach (char ch in foundEmoji)
                {
                    emojiSum += ch;
                }

                if (coolTreshold <= emojiSum)
                {
                    coolEmojie.Add(match.Value);
                }
            }
           
            Console.WriteLine($"{foundEmojie.Count} emojis found in the text. The cool ones are:");
            foreach (string emojies in coolEmojie)
            {
                Console.WriteLine(emojies);
            }


           
        }
    }
}
