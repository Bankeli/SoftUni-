namespace _03.CustomMiniFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int min = Aggregate(numbers, int.MaxValue, Math.Min);

            Console.WriteLine(min);
            
        }

        static int Aggregate(int[] nums, int initialNum, Func<int, int, int> func)
        {
            int result = initialNum;
            foreach (int num in nums)
            {
                result = func(result, num);
            }

            return result;
        }
    }
}
