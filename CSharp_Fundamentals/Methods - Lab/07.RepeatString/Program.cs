namespace _07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            string repeatedString = RepeatString(text, count);
            Console.WriteLine(repeatedString);
        }

        private static string RepeatString(string str, int count)
        {
            string result = string.Empty;

            for (int i = 0; i < count; i++)
            {
                result += str;
            }
            return result;
        }

    }
}
