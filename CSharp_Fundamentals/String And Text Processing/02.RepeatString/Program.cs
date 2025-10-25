namespace _02.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();

            foreach (string str2 in str)
            {
                for (int i = 0; i < str2.Length; i++)
                {
                    Console.Write(str2);
                }
            }
        }
    }
}
