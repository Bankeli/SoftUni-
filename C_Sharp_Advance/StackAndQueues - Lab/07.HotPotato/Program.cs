/*
Lucas Jacob Noah Logan Ethan
10
 */

namespace _07.HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kids = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int rotation = int.Parse(Console.ReadLine());
            Queue<string> queue = new(kids);

            while (queue.Count > 1)
            {
                for (int i = 0; i < rotation - 1; i++)
                {
                   string currKid = queue.Dequeue();
                    queue.Enqueue(currKid);
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
