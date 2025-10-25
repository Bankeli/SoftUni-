namespace _04.TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            foreach (string banword in bannedWords)
            {
                string replacedString = new('*', banword.Length);
                text = text.Replace(banword, replacedString);   
            }
            Console.WriteLine(text);
        }
    }
}
