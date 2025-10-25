namespace _01.SignOfIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int number = int.Parse(Console.ReadLine());
            PrintSignWithText(number);
        }

        static void PrintSignWithText(int number)
        {
            if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative. ");
            }
            else if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive. ");
            }
            else 
            {
                Console.WriteLine($"The number {number} is zero. ");
            }

        }
    }
}
