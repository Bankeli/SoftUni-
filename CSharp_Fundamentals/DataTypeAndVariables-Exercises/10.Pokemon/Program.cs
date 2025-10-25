namespace _10.Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustion = int.Parse(Console.ReadLine());

            int pokeCounter = 0;
            double halfPower = pokePower * 0.5d;

            while (pokePower >= distance)
            { 
                pokePower -= distance;
                pokeCounter++;

                if (pokePower == halfPower && pokePower != 0 && exhaustion != 0)
                { 
                    pokePower /= exhaustion;
                }
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(pokeCounter);




        }
    }
}
