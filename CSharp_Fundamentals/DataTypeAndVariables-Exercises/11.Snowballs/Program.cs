using System.Numerics;

namespace _11.Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int snowballs = int.Parse(Console.ReadLine());
            int bestSnow = 0, bestTime = 0, bestQuality = 0;
            BigInteger bestValue = 0; ;

            for (int i = 0; i < snowballs; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                BigInteger bestBallFormula = BigInteger.Pow(snow / time, quality);

                if (bestBallFormula > bestValue)
                {
                    bestValue = bestBallFormula;
                    bestSnow = snow;
                    bestTime = time;
                    bestQuality = quality;
                }

            }
            Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");
        }
    }
}
