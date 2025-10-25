namespace ArrayModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "decrease")
                {
                    for (int i = 0; i < numbers.Length ; i++)
                    {
                        numbers[i] -= 1;
                    }
                }
                else if (command != "decrease")
                {
                    string[] arguments = command.Split();
                    string action = arguments[0];
                    int index1 = int.Parse(arguments[1]);
                    int index2 = int.Parse(arguments[2]);

                    if (action == "swap")
                    {
                        int temp = numbers[index1];
                        numbers[index1] = numbers[index2];
                        numbers[index2] = temp;

                    }
                    else if (action == "multiply")
                    {
                        int result = numbers[index1] * numbers[index2];
                        numbers[index1] = result;
                    }

                }
            }
                Console.WriteLine(string.Join(", ", numbers));

        }
    }
}
