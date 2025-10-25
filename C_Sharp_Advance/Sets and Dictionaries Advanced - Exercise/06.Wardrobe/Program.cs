namespace _06.Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> WardrobeMap = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string color = input[0];
                string[] clothes = input[1].Split(",",StringSplitOptions.RemoveEmptyEntries);

                if (!WardrobeMap.ContainsKey(color))
                {
                    WardrobeMap[color] = new Dictionary<string, int>();
                }

                foreach (var cloth in clothes)
                {
                    if (!WardrobeMap[color].ContainsKey(cloth))
                    {
                        WardrobeMap[color][cloth] = 0;
                    }
                    WardrobeMap[color][cloth]++;
                 }
            }
            string[] searchQuery = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string searchedColor = searchQuery[0], searchedItem = searchQuery[1];
            foreach (var (color, item) in WardrobeMap)
            {
                Console.WriteLine($"{color} clothes:");
                foreach (var (clothes, count) in item)
                {
                    Console.Write($"* {clothes} - {count}");

                    if (color == searchedColor && clothes == searchedItem)
                        Console.Write(" (found!)");

                    Console.WriteLine();
                }
            }
        }
    }
}
