using System.Text;
using System.Text.RegularExpressions;

namespace _02.Race
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine().Split(",",StringSplitOptions.RemoveEmptyEntries).Select(p => p.Trim()).ToArray();
            string lettersPatern = @"[A-Za-z]";
            string digitPatern = @"[\d]";

            Dictionary<string, int> participantsData = new();

            for (int i = 0; i < participants.Length; i++)
            {
                participantsData.Add(participants[i].Trim(),0);
            }

            string command = String.Empty;

            while ((command = Console.ReadLine()) != "end of race")
            {
                StringBuilder sb = new StringBuilder();

                foreach (Match match in Regex.Matches(command, lettersPatern))
                {
                    sb.Append(match.Value);
                }

                string name = sb.ToString();
                int distance = 0;
                foreach (Match match in Regex.Matches(command, digitPatern))
                {
                    distance += int.Parse(match.Value);
                }

                if (participants.Contains(name))
                {
                    participantsData[name] += distance;
                }
            }

            var ordered = participantsData
               .OrderByDescending(x => x.Value)
               .Take(3)
               .ToList();

            string[] places = { "1st", "2nd", "3rd" };

            for (int i = 0; i < ordered.Count; i++)
            {
                Console.WriteLine($"{places[i]} place: {ordered[i].Key}");
            }
        }
    }
}
