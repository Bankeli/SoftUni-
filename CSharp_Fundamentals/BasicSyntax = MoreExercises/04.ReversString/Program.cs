namespace _04.ReversString
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();
            string output = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                char currentChar = input[i];
                output += currentChar;
                
            }
            Console.WriteLine(output);
        }

        
    }
}
