namespace _02.PrintNumbersInReversOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] numbers = new int[number];

            for (int i = 0; i < number; i++)
            {
                int n = int.Parse(Console.ReadLine());
                numbers[i] = n;
            }
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write($"{numbers[i]} ");
                
            }
        }
        
    }
}
