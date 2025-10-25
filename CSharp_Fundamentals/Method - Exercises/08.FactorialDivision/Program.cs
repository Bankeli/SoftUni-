

namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            double divisionresult = FactorialCalculation(num1) / FactorialCalculation(num2);
            Console.WriteLine($"{divisionresult:f2}");
        }

        static double FactorialCalculation(int number)
        {
            double result = number;
            for (int i = number - 1; i >= 1; i--)
            {
                result *= i;
            }
            return result;
        }

        

        
    }
}
