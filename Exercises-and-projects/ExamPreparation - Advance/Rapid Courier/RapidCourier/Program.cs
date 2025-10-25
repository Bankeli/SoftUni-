namespace RapidCourier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var packages = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            var courier = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Stack<int>packs = new Stack<int>(packages);
            Queue<int>couriers = new Queue<int>(courier);

            int totalWeightDelivered = 0;

            while (packs.Count > 0 && couriers.Count > 0)
            {
                int currentPack = packs.Peek();
                int currentCourier = couriers.Dequeue();

                if (currentCourier >= currentPack)
                {
                    currentCourier -= currentPack * 2;
                    if (currentCourier > 0)
                        couriers.Enqueue(currentCourier);

                    totalWeightDelivered += currentPack;
                    packs.Pop();
                }
                else if (currentCourier < currentPack)
                {
                    totalWeightDelivered += currentCourier;
                    currentPack -= currentCourier;
                    packs.Pop();
                    packs.Push(currentPack);
                    if (currentPack <= 0)
                        packs.Pop();
                }

                if (packs.Count == 0 || couriers.Count == 0)
                {
                    break;
                }
                

            }

                Console.WriteLine($"Total weight: {totalWeightDelivered} kg");
            if (packs.Count == 0 && couriers.Count == 0)
            {
                Console.WriteLine($"Congratulations, all packages were delivered successfully by the couriers today.");
            }
            else if (packs.Count == 0)
            {
                Console.WriteLine($"Couriers are still on duty: {string.Join(", ", couriers)} but there are no more packages to deliver.");
            }
            else
                Console.WriteLine($"Unfortunately, there are no more available couriers to deliver the following packages: {string.Join(", ", packs)}");
        }
    }
}
