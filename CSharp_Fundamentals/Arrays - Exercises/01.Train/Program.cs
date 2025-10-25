using System.Diagnostics.CodeAnalysis;

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagoonsNumber = int.Parse(Console.ReadLine());
            int[] train = new int[wagoonsNumber];
            int sum = 0;

            for (int i = 0; i < wagoonsNumber; i++)
            {
                int passangers = int.Parse(Console.ReadLine());
                train[i] = passangers;
                sum += passangers;
            }
            Console.WriteLine(string.Join(" ", train));
            Console.WriteLine(sum);
        }
    }
}
