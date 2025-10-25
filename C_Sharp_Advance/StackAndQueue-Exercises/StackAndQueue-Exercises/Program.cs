namespace StackAndQueue_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            int nElements = int.Parse(inputs[0]);
            int popingElemnts = int.Parse(inputs[1]);
            int elementForFind = int.Parse(inputs[2]);


            Stack<int> numbers = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            for (int i = 0; i < popingElemnts; i++)
            {
                numbers.Pop();
            }

            if (numbers.Contains(elementForFind))
            {
                Console.WriteLine("true");
            }
            else if (numbers.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                  
                Console.WriteLine(numbers.Min());
            }
        }
    }
}
