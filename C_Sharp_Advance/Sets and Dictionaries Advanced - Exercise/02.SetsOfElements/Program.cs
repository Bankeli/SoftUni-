using System.Collections.Generic;

namespace _02.SetsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lenght = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = lenght[0];
            int m = lenght[1];
            List<int> list = new List<int>();
            HashSet<int> first = ReadHash(n), seconod = ReadHash(m);

            foreach (int number in first)
            {
                if (seconod.Contains(number))
                    list.Add(number);
            }

            Console.WriteLine(string.Join(" ",list));
        }

        static HashSet<int> ReadHash(int lenght)
        {
            HashSet<int> result = new HashSet<int>();

            for (int i = 0; i < lenght; i++)
            {
                int num = int.Parse(Console.ReadLine());
                result.Add(num);
            }

            return result;
        }
    }
}
