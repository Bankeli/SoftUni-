namespace _02.StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           Stack<int> numbers = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));

            string input = string.Empty;

            while ((input = Console.ReadLine().ToLower()) != "end")
            {
                string[] coins = input.Split();
                string action = coins[0];

                if (action == "add")
                {
                    int num1 = int.Parse(coins[1]);
                    int num2 = int.Parse(coins[2]);

                    numbers.Push(num1);
                    numbers.Push(num2);
                }
                else if (action == "remove")
                {
                    int index = int.Parse(coins[1]);
                    if (numbers.Count >= index)
                    {
                        for (int i = 0; i < index; i++)
                        {
                            numbers.Pop();
                        }
                    }
                }
            }
            int sum = numbers.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
