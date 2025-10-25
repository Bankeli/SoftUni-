namespace _01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            SortedDictionary<double, int> numbersCount = new SortedDictionary<double, int>();

            foreach (double number in numbers)
            {
                if (numbersCount.ContainsKey(number))
                {
                    numbersCount[number]++;
                }
                else
                {
                    numbersCount.Add(number, 1);
                }
            }

            foreach ((double number, int count) in numbersCount)
            {
                Console.WriteLine($"{number} -> {count}");
            }


        }
    }
}
