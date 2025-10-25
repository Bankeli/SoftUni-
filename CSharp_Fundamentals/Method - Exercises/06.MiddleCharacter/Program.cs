namespace _06.MiddleCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string someText = Console.ReadLine();
            GetMiddleCharacter(someText);
        }

        static void GetMiddleCharacter(string text)
        {
            if (text.Length % 2 == 0)
            {
                Console.WriteLine(text.Substring((text.Length / 2) - 1, 2));
            }
            else
            {
                Console.WriteLine(text[text.Length / 2]);
            }
        }
    }
}
