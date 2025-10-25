using System.Runtime.InteropServices;

namespace ActivationKey
{
    internal class Program
    {
        public static string RawKey { get; set; }
        static void Main(string[] args)
        {
             RawKey = Console.ReadLine();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Generate")
            {
                string[] datas = input.Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                string action = datas[0];

                switch (action)
                {
                    case "Contains":
                        Contains(datas[1]);
                        break;
                    case "Flip":
                        Flip(datas[1], int.Parse(datas[2]), int.Parse(datas[3]));
                        break ;
                    case "Slice":
                        Slice(int.Parse(datas[1]), int.Parse(datas[2]));
                        break;
                }
            }

            Console.WriteLine($"Your activation key is: {RawKey}");
        }


        private static void Contains(string substring)
        {
            if (RawKey.Contains(substring))
            {
                Console.WriteLine($"{RawKey} contains {substring}");
            }
            else
            {
                Console.WriteLine("Substring not found!");
            }
        }

        private static void Flip(string command, int startIndex, int endIndex)
        {
            string prefix = RawKey.Substring(0, startIndex);
            string middle = RawKey.Substring(startIndex, endIndex - startIndex);
            string sufix = RawKey.Substring(endIndex);

            if (command == "Upper")
            {
                middle = middle.ToUpper();
            }
            else
                middle = middle.ToLower();

            RawKey = $"{prefix}{middle}{sufix}";

            Console.WriteLine(RawKey);
        }
        private static void Slice(int startIndex, int endIndex)
        {

            RawKey = RawKey.Remove(startIndex, endIndex - startIndex);
            Console.WriteLine(RawKey);
        }
    }
}
