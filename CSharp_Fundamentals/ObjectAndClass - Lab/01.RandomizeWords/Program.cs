namespace _01.RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Random index = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int randomIndex = index.Next(0, words.Length);
                Swap(i, randomIndex, words);
            }

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
        static void Swap(int index1, int index2, string[] words) 
        {
            string tempWord = words[index1];
            words[index1] = words[index2];
            words[index2] = tempWord;
        }
    }

}
