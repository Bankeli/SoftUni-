namespace _06.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {

                string[] arguments = command.Split();
                switch (arguments[0])
                {
                    case "Add":
                            int number = int.Parse(arguments[1]);
                        numbers.Add(number);
                            break;
                    case "Remove":
                        int num = int.Parse(arguments[1]);
                        numbers.Remove(num);
                        break;
                    case "RemoveAt":
                        int index = int.Parse(arguments[1]);
                        numbers.RemoveAt(index);
                        break;
                    case "Insert":
                        int nums = int.Parse (arguments[1]);
                        int addedIndex = int.Parse(arguments[2]);
                        numbers.Insert(addedIndex, nums);
                        break;

                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
