namespace _08.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (sum == numbers[i] + numbers[j])
                    {
                        Console.Write(numbers[i] + " " + numbers[j]);
                    Console.WriteLine();
                    }
                }
            }  
        }
    }
}
