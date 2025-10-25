namespace _04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rotation = int.Parse(Console.ReadLine());
            int lenght = numbers.Length;

            for (int i = 0; i < rotation; i++) 
            {
            int firstElement = numbers[0];
                for (int j = 0; j < lenght - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }
                numbers[lenght - 1 ] = firstElement;
               
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
