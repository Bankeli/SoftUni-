namespace _03.Largest3Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderByDescending(n => n)
                .Take(3)
                .ToList();

                Console.WriteLine(string.Join(" ",numbers));
            
        }
    }
}
