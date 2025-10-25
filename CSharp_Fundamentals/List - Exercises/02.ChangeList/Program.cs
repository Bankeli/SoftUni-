namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] arguments = input.Split();
                string action = arguments[0];
                int element = int.Parse(arguments[1]);

                switch (action)
                {
                    case "Delete":
                        DeleteElement(list, element);
                        break;

                    case "Insert":
                        int index = int.Parse(arguments[2]);
                        InsertElement(list, element, index);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ",list));
        }

        static void DeleteElement(List<int> list, int element)
        {
            list.RemoveAll(x => x == element);
        }

        static void InsertElement(List<int> list, int element, int index)
        {
            list.Insert(index, element);
        }
    }
}
