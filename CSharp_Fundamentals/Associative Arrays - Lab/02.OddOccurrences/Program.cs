namespace _02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            Dictionary<string, int> oddWordsCount = new();
            foreach (string word in input)
            {
            string wordInLower = word.ToLower();

                if (oddWordsCount.ContainsKey(wordInLower))
                {
                    oddWordsCount[wordInLower]++;
                }
                else
                {
                    oddWordsCount.Add(wordInLower, 1);
                }
            }

            foreach (string word in oddWordsCount.Keys)
            {
                if (oddWordsCount[word] % 2 != 0)
                {
                    Console.Write(word + " ");
                }
            }
        }
    }
}
