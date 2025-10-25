using System.Text;

namespace _06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string result = RemoveConsecutiveDuplicates(text);
            Console.WriteLine(result);

        }

        static string RemoveConsecutiveDuplicates(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            StringBuilder result = new StringBuilder();
            char previousChar = input[0];
            result.Append(previousChar);

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != previousChar)
                {
                    result.Append(input[i]);
                    previousChar = input[i];
                }
            }

            return result.ToString();
        }
    }
}
