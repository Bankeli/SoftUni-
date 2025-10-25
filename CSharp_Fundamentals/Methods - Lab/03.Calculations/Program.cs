using System.Data;

namespace _03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (command == "add")
            {
                AddNumber(num1, num2);
            }
            else if (command == "multiply")
            {
                MultiplyNumbers(num1, num2);
            }
            else if (command == "subtract")
            {
                SubtractNumbers(num1, num2);
            }
            else if (command == "divide")
            {
                if (num1 == 0|| num2 == 0) 
                    return;
                DividedNumbers(num1, num2);

            }
           
            

        }
        
        static void AddNumber (int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine(result);
        }
        static void MultiplyNumbers(int num1, int num2)
        {
          int result = (num1 * num2);
            Console.WriteLine(result);
        }
        static void SubtractNumbers (int num1, int num2)
        {
            int result = num1 - num2;
            Console.WriteLine(result);
        }
        static void DividedNumbers (int num1, int num2)
        {
            int result = num1 / num2;
            Console.WriteLine(result);
        }
    }
}
