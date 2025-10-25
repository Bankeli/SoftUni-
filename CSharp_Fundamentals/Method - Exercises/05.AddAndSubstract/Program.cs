
namespace _05.AddAndSubstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int finalResult = SubstractThirdIntFromSum(num1, num2, num3);
            Console.WriteLine(finalResult);
            
        }

        private static int SumOfFirstDigit(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;
            return sum;
        }

        static int SubstractThirdIntFromSum(int n1, int n2, int n3)
        {
            int sum = SumOfFirstDigit(n1, n2);
            int result = sum - n3;
            return result;
        }
    }
}
