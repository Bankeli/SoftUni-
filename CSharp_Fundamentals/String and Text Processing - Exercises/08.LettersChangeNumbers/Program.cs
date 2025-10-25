namespace _08.LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double totalSum = 0;

            foreach (string line in input)
            {
                char firstLetter = line[0];
                char lastLetter = line[line.Length - 1];

                uint numbers = uint.Parse(line.Substring(1, line.Length - 2));

                if (char.IsUpper(firstLetter))
                    totalSum += numbers /(double) GetPositionInAlphabet(firstLetter);
                else if (char.IsLower(firstLetter))
                    totalSum += numbers * GetPositionInAlphabet(firstLetter);

                if (char.IsUpper(lastLetter))
                    totalSum -= GetPositionInAlphabet(lastLetter);
                else if (char.IsLower(lastLetter))
                    totalSum += GetPositionInAlphabet(lastLetter);
            }

            Console.WriteLine($"{totalSum:f2}");
        }

        private static int GetPositionInAlphabet(char letter)
        {
            int charPosition = char.IsUpper(letter) ? 'A' : 'a';
            return (letter - charPosition + 1);
        }
    }
}
