namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bestStartIndex = 0;
            int bestLength = 1;

            int currentStartIndex = 0;
            int currentLength = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    currentLength = 1;
                    currentStartIndex = i;
                }

                if (currentLength > bestLength)
                {
                    bestLength = currentLength;
                    bestStartIndex = currentStartIndex;
                }
            }

            for (int i = 0; i < bestLength; i++)
            {
                Console.Write(numbers[bestStartIndex] + " ");
            }

            Console.WriteLine();
        }
    }
}
