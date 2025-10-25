namespace _08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine()); 

            double poweredNumber = ReturnPoweredNumber(number, power);
            Console.WriteLine(poweredNumber);

        }

        private static double ReturnPoweredNumber(double number, int power)
        {
                double result = 1d;
            if (number != 0 && power != 0)
            {

                for (int i = 1; i <= power; i++)
                {
                    result *= number;
                }
            }
                return result;
            
        }
    }
}
