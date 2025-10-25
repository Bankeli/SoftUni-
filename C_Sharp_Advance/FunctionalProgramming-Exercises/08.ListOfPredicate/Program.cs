namespace _08.ListOfPredicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] dividers = Console.ReadLine().Split().Select(int.Parse).ToArray();

          var result =  InRange(1, n, x => dividers.All(y => x % y == 0));
            Console.WriteLine(string.Join(" ", result));
        }

        static int[] InRange(int start, int end, Func<int, bool> condition)
        {

            List<int> result = new List<int>();
            for (int i = start; i <= end; i++)
            {
                if (condition(i))
                    result.Add(i);
            }

            return result.ToArray();
        }
    }
}
