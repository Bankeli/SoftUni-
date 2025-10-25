using System.Threading.Channels;

namespace _02.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
            .Split(", ")
            .Select(int.Parse)
            .ToList();

            Console.WriteLine(numbers.Count);
            Console.WriteLine(numbers.Sum());
        }
    }
}
