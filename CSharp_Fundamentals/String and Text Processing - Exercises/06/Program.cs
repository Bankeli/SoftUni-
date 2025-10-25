using System.Text;

namespace _06_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            char currChar = text[0];
            sb.Append(currChar);

            for (int i = 1; i <= text.Length - 1; i++)
            {
                if (text[i] != currChar )
                {
                currChar = text[i];
                sb.Append(currChar);
                }
            }

            Console.WriteLine(sb);
        }
    }
}
