namespace _01.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = string.Empty;

            while ((text = Console.ReadLine()) != "end")
            {
                GetReversedString(text);

            }
        }

        private static void GetReversedString(string text)
        {
            string reversedString = string.Empty;

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversedString += text[i];
            }
            Console.WriteLine($"{text} = {reversedString}");
        }
    }
}
