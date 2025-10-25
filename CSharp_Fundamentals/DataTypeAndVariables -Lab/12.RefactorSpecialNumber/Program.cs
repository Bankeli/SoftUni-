namespace _12.RefactorSpecialNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            
            for (int i = 1; i <= number; i++)
            {
                int sum = 0;
                int digit = i;
                
                while (digit > 0)
                {
                    sum += digit % 10;
                    digit /= 10;
                }
                bool isSpecial = false;
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                if (isSpecial)
                    Console.WriteLine("{0} -> {1}", i, isSpecial);
                else Console.WriteLine("{0} -> {1}", i, isSpecial);


            }
        }
    }
}
