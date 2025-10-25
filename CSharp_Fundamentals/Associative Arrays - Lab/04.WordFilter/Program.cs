using System.Threading.Channels;

namespace _04.WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().Where(w => w.Length % 2 == 0).ToArray();

            Console.Write(string.Join("\n", words));
        }
    }
}
