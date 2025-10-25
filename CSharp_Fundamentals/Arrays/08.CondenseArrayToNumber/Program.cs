namespace _08.CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] startingNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            while (startingNumbers.Length > 1)
            {
                int[] condense = new int[startingNumbers.Length - 1];


                for (int i = 0; i < condense.Length; i++)
                {
                    condense[i] = startingNumbers[i] + startingNumbers[i + 1];
                }
                startingNumbers = condense;
            }
            Console.WriteLine(startingNumbers[0]);
        }
    }
}
