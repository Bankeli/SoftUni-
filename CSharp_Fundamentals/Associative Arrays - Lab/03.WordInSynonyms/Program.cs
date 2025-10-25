namespace _03.WordInSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wordCount = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> wordsSynonym = new();

            for (int i = 0; i < wordCount; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!wordsSynonym.ContainsKey(word))
                {
                    wordsSynonym.Add(word, new List<string>());
                }
               
                    wordsSynonym[word].Add(synonym);
                

            }

            foreach ((string word, List<string> synonyms) in wordsSynonym) 
            {
                Console.WriteLine($"{word} - {(string.Join(", ", synonyms))}");
            }
        }
    }
}
