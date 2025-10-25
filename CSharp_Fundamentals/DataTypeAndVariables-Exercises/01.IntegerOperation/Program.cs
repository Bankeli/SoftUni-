namespace _01.IntegerOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());

            int sum = n1 + n2;
            int divide = sum / n3;
            int multiply  = divide * n4;

            Console.WriteLine(multiply);
        }
    }
}
