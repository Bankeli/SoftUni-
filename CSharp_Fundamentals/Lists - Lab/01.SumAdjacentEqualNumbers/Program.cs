namespace _01.SumAdjacentEqualNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine().Split().Select(decimal.Parse).ToList();

            bool hasEqual = true;

            while (hasEqual)
            {
                hasEqual = false;

                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        numbers[i] += numbers[i + 1];
                        numbers.RemoveAt(i+ 1);
                        hasEqual = true;
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
