namespace GenericCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<double> list = new List<double>(capacity: n);

            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                list.Add(num);
            }

            double value = double.Parse(Console.ReadLine());
            int result = CountGreater(list, value);
                Console.WriteLine(result);
        }

        static int CountGreater<T>(List<T> list, T compareValue)
        {
            int count = 0;
            foreach (T el in list)
            {
                int compareResult = Comparer<T>.Default.Compare(el, compareValue);
                if (compareResult > 0) count++;
            }
            return count;
        }
    }
}
