namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n1 = int.Parse(Console.ReadLine());
           int n2 = int.Parse(Console.ReadLine());
           int n3 = int.Parse(Console.ReadLine());

            PrintSmallestNumber(n1, n2, n3);
        }

        static void PrintSmallestNumber(int num1, int num2, int num3)
        {
            int smallestNumber = num1;

            if (smallestNumber > num2)
                smallestNumber = num2;
             if (smallestNumber > num3)
                smallestNumber = num3;

            Console.WriteLine(smallestNumber);
        }
    }
}
