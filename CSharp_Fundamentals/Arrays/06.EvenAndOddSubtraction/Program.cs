namespace _06.EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int oddsum = 0;
            int evensum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                if( number[i] % 2 == 0) 
                    evensum += number[i];
                else if ( number[i] % 2 != 0)
                    oddsum += number[i];
            }
            Console.WriteLine($"{evensum - oddsum}");
        }
    }
}
