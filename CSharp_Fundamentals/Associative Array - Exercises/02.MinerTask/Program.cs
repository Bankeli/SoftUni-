namespace _02.MinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, uint> resourcesMap = new Dictionary<string, uint>();

            string resourceKey = string.Empty;

            while ((resourceKey = Console.ReadLine()) != "stop")
            {

                if (!resourcesMap.ContainsKey(resourceKey))
                {
                    resourcesMap.Add(resourceKey, 0);
                }

                uint quantity = uint.Parse(Console.ReadLine());
                resourcesMap[resourceKey] += quantity;

            }

            foreach (KeyValuePair<string, uint> pairs in resourcesMap)
            {
                Console.WriteLine($"{pairs.Key} -> {pairs.Value}");
            }
        }
    }
}
