namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbersAsString = string.Empty;
            while ((numbersAsString = Console.ReadLine()) != "END")
            {
                if (numbersAsString == PrintReversedNumber(numbersAsString))
                    Console.WriteLine("true");
                else
                    Console.WriteLine("false");
            }
        }

        static string PrintReversedNumber (string numbers)
        {
            string reversedNumber = string.Empty;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                char currChar = numbers[i];
                reversedNumber += currChar;
            }
            return reversedNumber;
        }
    }
}
