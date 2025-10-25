namespace OffRoadChallange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var initialFuel = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            var consumptionIndex = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            var neededFuel = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            int counter = 0;
            

            while (initialFuel.Count > 0 && consumptionIndex.Count > 0 && neededFuel.Count > 0) 
            {
                int result = initialFuel.Pop() - consumptionIndex.Dequeue();

                if (result >= neededFuel.Peek())
                {
                    neededFuel.Dequeue();
                    counter++;
                    Console.WriteLine($"John has reached: Altitude {counter}");

                }
                else
                {
                    Console.WriteLine($"John did not reach: Altitude {counter + 1}");
                    break;  
                } 
            }
            if (neededFuel.Count == 0)
                Console.WriteLine("John has reached all the altitudes and managed to reach the top!");

            else 
            {
                Console.WriteLine("John failed to reach the top.");
                if (counter == 0)
                    Console.WriteLine("John didn't reach any altitude.");
                else
                    PrintAltitude(counter);
            }
            
        }

        static void PrintAltitude(int counter)
        {
                Console.Write("Reached altitudes: ");
            for (int i = 0; i < counter; i++)
            {
                if (i == counter - 1)
                    Console.Write($"Altitude {i + 1}");
                else
                    Console.Write($"Altitude {i + 1}, ");
            }
            Console.WriteLine();
        }
    }
}
