namespace _11.MathOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

           double result = GetMathResult(firstNum, operation, secondNum);
            Console.WriteLine(result);
        }

        static double GetMathResult(double firstNum, char operation, double secondNum)
        {
            double result = 0;
            if (operation == '+')
                result = firstNum + secondNum;
            else if (operation == '-') result = firstNum - secondNum;
            else if (operation == '*') result = firstNum * secondNum;
            else if (operation == '/' && firstNum != 0 && secondNum != 0) result = firstNum / secondNum;
            
                

                return result;
        }
    }
}
