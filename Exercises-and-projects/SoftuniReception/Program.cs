using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace SoftuniReception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstWorker = int.Parse(Console.ReadLine());
            int secondWorker = int.Parse(Console.ReadLine());
            int thirdWorker = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            int totalStudentsPerHour = firstWorker + secondWorker + thirdWorker;
            int count = 0;
            while (students > 0)
            {
                count++;

                if (count % 4 == 0)
                {
                    continue;
                }
                students -= totalStudentsPerHour;
            }
            Console.WriteLine($"Time needed: {count}h.");

        }

    }
}