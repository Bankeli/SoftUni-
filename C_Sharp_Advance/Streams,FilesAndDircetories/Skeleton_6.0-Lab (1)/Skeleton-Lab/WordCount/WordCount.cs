namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using static System.Net.Mime.MediaTypeNames;

    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {

            string[] wordsToFind = File.ReadAllText(wordsFilePath)
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(w => w.ToLower())
                .ToArray();

            Dictionary<string, int> wordMap = new();

            foreach (string word in wordsToFind)
            {
                if (!wordMap.ContainsKey(word))
                {
                    wordMap[word] = 0;
                }
            }

            string text = File.ReadAllText(textFilePath).ToLower();

            char[] separator = new char[] { ' ', ',', '.', '!', '?', '-', '\r', '\n' };

            string[] textWords = text.ToLower().Split((separator)).ToArray();

            foreach (var word in textWords)
            {
                if (wordMap.ContainsKey(word))
                    wordMap[word]++;
            }

            var orderedMap = wordMap.OrderByDescending(count => count.Value);

            using var writer = new StreamWriter(outputFilePath);

            foreach (var (word, count) in orderedMap)
            {
                writer.WriteLine($"{word} - {count}");
            }
        }
    }
}
