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


            Queue<int> numbers = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            if (numbers.Any())
            {
                for (int i = 0; i < popingElemnts; i++)
                {
                    numbers.Dequeue();
                }

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
                int smallestNum = numbers.Dequeue();
                while  (numbers.Count > 0)
                {
                    int currNum = numbers.Dequeue();
                    if (smallestNum > currNum)
                    {
                        smallestNum = currNum;
                    }
                }
                Console.WriteLine(smallestNum);
            }
        }
    }
}
