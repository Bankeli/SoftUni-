namespace _10.TopNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lastNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= lastNumber; i++)
            {
                if (IsTopNumber(i))
                    Console.WriteLine(i);
            }


        }

        static bool IsTopNumber(int num)
        {
            if (IsHaveOddNumber(num) && DivisibleByEight(num))
            {
                return true;
            }
            return false;
        }

        static bool IsHaveOddNumber(int numbers)
        {
            while (numbers > 0)
            {
                int digit = numbers % 10;
                numbers /= 10;
                if (digit % 2 != 0)
                {
                    return true;
                }
            }
            return false;
        }

        static bool DivisibleByEight(int number)
        {
            int sumOfDigits = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;
                sumOfDigits += lastDigit;
                number /= 10;
            }

            return sumOfDigits % 8 == 0;
        }
    }
}
