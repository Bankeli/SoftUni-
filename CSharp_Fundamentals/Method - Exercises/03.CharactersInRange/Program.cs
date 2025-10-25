namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());

            PrintSymbolsInTheRange(ch1, ch2);
        }

        static void PrintSymbolsInTheRange(char symbol1, char symbol2)
        {
                if (symbol1 > symbol2)
                {
                    char swapSimbol = symbol1;
                    symbol1 = symbol2;
                    symbol2 = swapSimbol;

                }
            for (char i = symbol1; i < symbol2; i++)
            {
            char symbols = default(char);
                symbols = i;
                if (i == symbol1)
                    continue;
                Console.Write(symbols + " ");
            }
        }
    }
}
