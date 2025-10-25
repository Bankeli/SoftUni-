using System;

namespace GetHeart
{
    internal class Program
    {




        static void Main()
        {
            int[] neighborhood = Console.ReadLine()
                .Split('@')
                .Select(int.Parse)
                .ToArray();

            string command;
            int position = 0;

            while ((command = Console.ReadLine()) != "Love!")
            {
                int jumpLength = int.Parse(command.Split()[1]);
                position += jumpLength;

                if (position >= neighborhood.Length)
                {
                    position = 0;
                }

                if (neighborhood[position] == 0)
                {
                    Console.WriteLine($"Place {position} already had Valentine's day.");
                }
                else
                {
                    neighborhood[position] -= 2;
                    if (neighborhood[position] == 0)
                    {
                        Console.WriteLine($"Place {position} has Valentine's day.");
                    }
                }
            }

            Console.WriteLine($"Cupid's last position was {position}.");

            int failedHouses = neighborhood.Count(h => h > 0);
            if (failedHouses == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {failedHouses} places.");
            }
        }
    }
}
