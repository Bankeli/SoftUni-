namespace PlayCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int exceptionCounter = 0;

            while (exceptionCounter < 3)
            {
                var command = Console.ReadLine().Split();
                string action = command[0];
                try
                {
                    switch (action)
                    {
                        case "Replace":
                            int index = int.Parse(command[1]);
                            int element = int.Parse(command[2]);
                            Replace(index, element, numbers);
                            break;
                        case "Print":
                            int start = int.Parse(command[1]);
                            int end = int.Parse(command[2]);
                            Print(start, end, numbers);
                            break;
                        case "Show":
                            int show = int.Parse(command[1]);
                            Show(show, numbers);
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("The variable is not in the correct format!");
                    exceptionCounter++;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("The index does not exist!");
                    exceptionCounter++;
                }
            }

            Console.WriteLine(string.Join(", ",numbers));
        }

        static void Replace(int index, int element, int[] values)
        {
            values[index] = element;
        }

        static void Print(int start, int end, int[] values)
        {
            List<int> numbers = new List<int>();
            for (int i = start; i <= end; i++)
            {
                numbers.Add(values[i]);
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
        static void Show(int index, int[] values)
        {
            Console.WriteLine(values[index]);
        }
    }
}
