namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();

            PrintVowelsCount(text);
        }

        static void PrintVowelsCount(string text)
        {
            int counter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char character = text[i];
                if (character == 'a' || character == 'o' || character == 'e' ||  character == 'u' ||  character == 'i')
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);

        }
    }
}
