namespace _04.AddVAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                 .Split(", ")
                 .Select(decimal.Parse)
                 .Select(n => n * 1.2m)
                 .Select(n => $"{n:f2}")
                 .ToList()
                 .ForEach(n => Console.WriteLine(n));
        }
    }
}
