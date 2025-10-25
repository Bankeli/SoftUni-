using System.Text;

namespace _07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            int power = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    sb.Append(input[i]);
                    string powerStr = input[i + 1].ToString();
                    int strenghtValue = int.Parse(powerStr);
                    power += strenghtValue;
                }
                else if (power == 0)
                {
                    sb.Append(input[i]);
                }
                else if (power > 0)
                    power--;

            }

            Console.WriteLine(sb);
        }
    }
}
