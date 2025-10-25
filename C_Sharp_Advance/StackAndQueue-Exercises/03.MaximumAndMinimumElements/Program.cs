using System.Diagnostics.Metrics;

namespace _03.MaximumAndMinimumElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nQueries = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            int counter = 0;
            string input = string.Empty;

            while (counter != nQueries)
            {
                input = Console.ReadLine();
                string[] tokens = input.Split();

                string commands = tokens[0];

                switch (commands)
                {
                    case "1":
                        int element = int.Parse(tokens[1]);
                        stack.Push(element);
                        break;
                    case "2":
                        if (stack.Any())
                            stack.Pop();
                        break;
                    case "3":
                        PrintMax(stack);
                        break;
                    case "4":
                        PrintMin(stack);
                        break;
                }
                counter++;
            }
            var numberStack = stack.ToArray();
            Console.WriteLine(string.Join(", ",stack));

        }

        private static void PrintMin(Stack<int> stack)
        {
            if (stack.Count > 0)
            {
                int smallestNum = stack.Min();

                Console.WriteLine(smallestNum);
            }
        }

        static void PrintMax(Stack<int> stack)
        {
            if (stack.Count > 0)
            {
                int biggestOne = stack.Max();
               
                Console.WriteLine(biggestOne);
            }
        }
    }
}
