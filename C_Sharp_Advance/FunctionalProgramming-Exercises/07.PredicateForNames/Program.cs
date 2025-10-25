namespace _07.PredicateForNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int namesLenght = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine().Split().ToList();

            Iterate(
                FilteredName(names, x => x.Length <= namesLenght),
                x => Console.WriteLine(x));
        }

        static List<string> FilteredName(List<string> names, Func<string, bool> condition)
        {
            List<string> namesList = new();

            foreach (string name in names)
            {
                if (condition(name))
                    namesList.Add(name);
            }

            return namesList;
        }

        static void Iterate(List<string> list, Action<string> action)
        {
            foreach (string name in list)
            {
                action(name);
            }
        }
    }
}
