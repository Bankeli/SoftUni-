namespace _09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint numberStarting = uint.Parse(Console.ReadLine());
            int spices = 0;
            int days = 0;

            while (numberStarting >= 100)
            {
                days++;
                spices += (int)numberStarting;
                spices -= 26;
                
                numberStarting-= 10;
            }
            if (numberStarting < 100 && days > 0)
            {
                spices -= 26;
            }
                
            Console.WriteLine(days);
            Console.WriteLine(spices);
        }
    }
}
