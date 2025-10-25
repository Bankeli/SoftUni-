namespace _01.CountCharsInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> charCounter = new Dictionary<char, int>();

            foreach (char ch in text)
            {
                if(ch != ' ')
                {
                    if(!charCounter.ContainsKey(ch))
                    {
                        charCounter[ch] = 0;
                    }
                    charCounter[ch]++;
                }

            }

            foreach ((char character, int counter) in charCounter)
            {
                Console.WriteLine($"{character} -> {counter}");
                
            }
        }
    }
}
