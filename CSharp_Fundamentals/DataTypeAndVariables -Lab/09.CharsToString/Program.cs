namespace _09.CharsToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstSimbol = char.Parse(Console.ReadLine());
            char secondSimbol = char.Parse(Console.ReadLine());
            char thirdSimbol = char.Parse(Console.ReadLine());

            Console.WriteLine($"{firstSimbol}{secondSimbol}{thirdSimbol}");
        }
    }
}
