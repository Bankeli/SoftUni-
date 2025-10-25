namespace _02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split();
            string str1 = strings[0];
            string str2 = strings[1];

            int maxLenght = Math.Max (str1.Length, str2.Length);

            double sum = 0;

            for (int i = 0; i < maxLenght; i++)
            {
                if (i < str1.Length && i <str2.Length)
                    sum += str1[i] * str2[i];
                else if (i < str1.Length)
                    sum += str1[i];
                else if (i < str2.Length)
                    sum += str2[i];
            }

            Console.WriteLine(sum);
        }
    }
}
