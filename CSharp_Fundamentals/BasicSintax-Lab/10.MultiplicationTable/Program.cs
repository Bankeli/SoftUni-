namespace _10.MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int multiply = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++) 
            {
                int result = multiply * i;
                Console.WriteLine($"{multiply} X {i} = {result}");
            }
        }
    }
}
