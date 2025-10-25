namespace _06.StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int workingNumber = number;

            while (workingNumber > 0)
            {
                int factorial = 1;
                int lastDigit = workingNumber % 10;
                workingNumber /= 10;
                for (int i = 1; i <= lastDigit; i++)
                {
                    factorial *= i;
                }
                sum += factorial;
            }

            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
                
        }
    }
}
