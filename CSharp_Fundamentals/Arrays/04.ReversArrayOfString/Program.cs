namespace _04.ReversArrayOfString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine()
                .Split()
                .ToArray();

            for (int i = 0; i < strings.Length / 2; i++)
            {
                string oldElement = strings[i];
               strings[i] = strings[strings.Length - 1 - i];
                strings[strings.Length - 1 - i] = oldElement;
            }
            Console.WriteLine(string.Join(" ", strings));
        }

    }
}
