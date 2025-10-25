namespace _04.FindEvenOrOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int start = range[0], end = range[1];

            string type = Console.ReadLine();

            List<int> result = new List<int>();
            if (type == "odd") result = FilteredNumbers(start, end, x => x % 2 != 0);
            else if (type == "even") result = FilteredNumbers(start, end, x => x % 2 == 0);

            Console.WriteLine(string.Join(' ', result));

        }

        static List<int> FilteredNumbers(int start, int end, Predicate<int> predicate)
        {
            List<int> list = new();
            for (int i = start; i <= end; i++)
            {
                if (predicate(i))
                    list.Add(i);
            }
            return list;
        }
    }
}
