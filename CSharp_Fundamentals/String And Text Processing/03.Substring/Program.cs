namespace _03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string keyWord = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(keyWord))
            {
                int index = text.IndexOf(keyWord);

                text = text.Remove(index,keyWord.Length);
            }

            Console.WriteLine(text);
        }
    }
}
