using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.StarEnigma
{
    internal class Program
    {
        public class Message
        {
            public Message(string planet, uint population, string type, int soldiers)
            {
                Planet = planet;
                Population = population;
                Type = type;
                SoldiersCount = soldiers;
            }
            public string Planet { get; set; }
            public uint Population { get; set; }
            public string Type { get; set; }
            public int SoldiersCount { get; set; }

        }
        static void Main(string[] args)
        {
            int msgCount = int.Parse(Console.ReadLine());
            string starPattern = @"[SsTtAaRr]";
            string msgPattern = @"\@(?<planet>[A-Za-z]+)[^\@\-\!\:\>]*\:(?<population>\d+)[^\@\-\!\:\>]*\!(?<type>A|D)\![^\@\-\!\:\>]*\-\>[^\@\-\!\:\>]*?(?<soldiers>\d+)[^\@\-\!\:\>]*";

            List<Message> messages = new List<Message>();
            for (int i = 0; i < msgCount; i++)
            {
                string encryptMsg = Console.ReadLine();

                int decryptKey = Regex.Matches(encryptMsg, starPattern).Count;

                StringBuilder sb = new StringBuilder();

                for (int j = 0; j < encryptMsg.Length; j++)
                {
                    sb.Append((char)(encryptMsg[j] - decryptKey));
                }

                string decriptedMsg = sb.ToString();

                var match = Regex.Match(decriptedMsg, msgPattern);

                if (Regex.IsMatch(decriptedMsg, msgPattern) == false)
                {
                    continue;
                }

                string planetName = match.Groups["planet"].Value;
                uint population = uint.Parse(match.Groups["population"].Value);
                string attackType = match.Groups["type"].Value;
                int soldiersCount = int.Parse(match.Groups["soldiers"].Value);

                Message newMsg = new Message(planetName,population,attackType,soldiersCount);
                messages.Add(newMsg);

            }

            var attackedPlanet = messages.Where(m => m.Type == "A")
                .OrderBy(m => m.Planet)
                .ToList();

            Console.WriteLine($"Attacked planets: {attackedPlanet.Count}");
            attackedPlanet.ForEach(m => Console.WriteLine($"-> {m.Planet}"));

             var destroyedPlanet = messages.Where(m => m.Type == "D")
                .OrderBy(m => m.Planet)
                .ToList();

            Console.WriteLine($"Destroyed planets: {destroyedPlanet.Count}");
            destroyedPlanet.ForEach(m => Console.WriteLine($"-> {m.Planet}"));
        }
    }
}
