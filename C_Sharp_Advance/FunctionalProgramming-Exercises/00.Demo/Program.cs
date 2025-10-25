namespace _00.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Iterate(names, el => Console.WriteLine($"Sir {el}"));
        }

        static void Iterate(string[] array, Action<string> action)
        {
            foreach(string el in  array)
                action(el);
        }
    }
}
