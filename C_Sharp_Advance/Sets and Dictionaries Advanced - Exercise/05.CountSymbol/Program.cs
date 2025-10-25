namespace _05.CountSymbol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Dictionary<char, int> CharMap = new();

            foreach (char ch in text)
            {
                if (!CharMap.ContainsKey(ch))
                {
                    CharMap[ch] = 0;
                }
                CharMap[ch]++;
            }

            CharMap = CharMap.OrderBy(x => x.Key).ToDictionary();

            foreach (var (ch, count) in CharMap)
            {
                Console.WriteLine($"{ch}: {count} time/s");
            }
        }
    }
}
