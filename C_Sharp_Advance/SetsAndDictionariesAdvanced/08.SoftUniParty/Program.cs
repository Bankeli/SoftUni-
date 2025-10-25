using System.Globalization;

namespace _08.SoftUniParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            HashSet<string> regularGuest = new();
            HashSet<string> vipGuest = new();
            bool isVip = false;
            while ((input = Console.ReadLine()) != "PARTY")
            {
                if (char.IsDigit(input[0]))
                {
                    isVip = true;
                    vipGuest.Add(input);
                }
                else regularGuest.Add(input);
            }
            while ((input = Console.ReadLine()) != "END")
            {
                if (vipGuest.Contains(input))
                {
                    vipGuest.Remove(input);
                }
                else if (regularGuest.Contains(input))
                {
                    regularGuest.Remove(input);
                }
            }

            Console.WriteLine($"{vipGuest.Count+regularGuest.Count}");
            foreach (var guest in vipGuest)
            {
                Console.WriteLine(guest);
            }
            foreach(var guest in regularGuest) Console.WriteLine(guest);
        }
    }
}
