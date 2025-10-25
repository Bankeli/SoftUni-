namespace _06.ReverseAndExclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            int[] result = InReverse(nums, x => x % n != 0);

            Console.WriteLine(string.Join(" ", result));
        }

        static int[] InReverse(int[] arr, Func<int, bool> condition)
        {

            List<int> list = new();
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (condition(arr[i]))
                    list.Add(arr[i]);
            }

            return list.ToArray();
        }
    }
}
