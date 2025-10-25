namespace _03.PeriodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<string> elements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] chemicalCompounds = Console.ReadLine().Split();

                foreach (string compound in chemicalCompounds) { elements.Add(compound); }
            }

            Console.WriteLine(string.Join(" ",elements));
            
        }
    }
}
