namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int capacity = 255;
            int littersInTheTank = 0;


            for (int i = 0; i < number; i++)
            {

                int litersToPour = int.Parse(Console.ReadLine());
                if (litersToPour + littersInTheTank > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else 
                {
                    littersInTheTank += litersToPour;
                }
            }
            Console.WriteLine(littersInTheTank);
        }
    }
}
