namespace _07.TruckTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] petrol = new int[n];
            int[] distance = new int[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                petrol[i] = int.Parse(input[0]);
                distance[i] = int.Parse(input[1]);
            }

            int total = 0;
            int currentPetrol = 0;
            int startIndex = 0;

            for (int i = 0; i < n; i++)
            {
                total += petrol[i] - distance[i];
                currentPetrol += petrol[i] - distance[i];

                if (currentPetrol < 0)
                {
                    startIndex = i + 1;
                    currentPetrol = 0;
                }
            }

            if (total >= 0) Console.WriteLine(startIndex);
        }
    }
}
