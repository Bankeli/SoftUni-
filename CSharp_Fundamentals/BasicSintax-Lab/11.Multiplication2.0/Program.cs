namespace _11.Multiplication2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int number = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            do
            {
                int result = number * multiplier;
                Console.WriteLine($"{number} X {multiplier} = {result}");
                multiplier++;
            }
            while (multiplier <= 10);
            
            
        }
    }
}
