using System.Reflection.Metadata;

namespace _05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> field = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bomb = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int specialNum = bomb[0];
            int reach = bomb[1];

            while (field.Contains(specialNum))
            {
                BombDetonationRange(field, specialNum, reach);
            }
            Console.WriteLine(field.Sum());
        }

        private static void BombDetonationRange(List<int> field, int specialNum, int reach)
        {
            int specialIndex = field.IndexOf(specialNum);
            int startIndex = Math.Max(0, specialIndex - reach);
            int endIndex = Math.Min(field.Count - 1, specialIndex + reach);
            int rangeLenght = endIndex - startIndex + 1;

            field.RemoveRange(startIndex, rangeLenght);
        }
    }
}
