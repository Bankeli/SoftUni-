namespace _06.EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            bool isFound = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                leftSum = numbers.Take(i).Sum();
                rightSum = numbers.Skip(i + 1).Sum();
                if (leftSum == rightSum)
                {
                    isFound = true;
                    Console.WriteLine(i);
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("no");
            }


        }
    }
}
