namespace MissionToMars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> resourcesMap = new Dictionary<string, int>
            {
                {"Iron",80 },
                {"Titanium",90 },
                {"Aluminium",100},
                {"Chlorine", 60 },
                {"Sulfur",70 }
            };
            Queue<string> resources = new Queue<string>(resourcesMap.Keys);
            List<string> collectedResources = new List<string>();

            Stack<int> solarEnergy = new Stack<int>(Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
           Queue<int> distance = new Queue<int>(Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));


            while (solarEnergy.Count > 0 && distance.Count > 0 && resources.Count > 0)
            {
                int dailyEnergy = solarEnergy.Pop();
                int dailyDistance = distance.Dequeue();
                int dailyBotCapacity = dailyDistance + dailyEnergy;
                var currResource = resources.Peek();
                int resourcesInKilos = resourcesMap[currResource];

                if (dailyBotCapacity >= resourcesInKilos)
                
                    collectedResources.Add(resources.Dequeue());
            }

            if (resources.Count == 0)
            {
                Console.WriteLine("Mission complete! All minerals have been collected.");
            }
            else
            {
                Console.WriteLine("Mission not completed! Awaiting further instructions from Earth.");
            }

            if (collectedResources.Count > 0)
            {
                Console.WriteLine("Collected resources:");
                foreach (var resource in collectedResources)
                {
                    Console.WriteLine(resource);
                }
            }
        }
    }
}
