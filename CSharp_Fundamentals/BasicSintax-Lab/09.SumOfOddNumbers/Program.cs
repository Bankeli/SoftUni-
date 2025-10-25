namespace _09.SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                int oddNumber = 2 * i - 1;
                sum += oddNumber;
                Console.WriteLine(oddNumber);
                
            }
            Console.WriteLine($"Sum: {sum}");

        }
    }
}
