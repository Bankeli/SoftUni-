namespace _03.Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int[] evenArray = new int[num];
            int[] oddArray = new int[num];

            for (int i = 1; i <= num; i++) 
            {
                int[] input = Console.ReadLine().Split() .Select(int.Parse).ToArray();

                if (i % 2 != 0)
                {
                    evenArray[i - 1] = input[0];
                    oddArray[i - 1] = input[1];
                }
                else 
                {
                    evenArray[i - 1] = input[1];
                    oddArray[i - 1] = input[0];
                }
            }
            Console.Write(string.Join(" ", evenArray));
            Console.WriteLine();
            Console.Write(string.Join(" ", oddArray));
        }
    }
}
