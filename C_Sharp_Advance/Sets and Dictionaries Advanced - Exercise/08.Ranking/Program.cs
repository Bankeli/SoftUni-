namespace _08.Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input = string.Empty;
            Dictionary<string, string> ContestPasswordMap = new();
            Dictionary<string, Dictionary<string, int>> UserContestPointsMap = new();
            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] data = input.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string contest = data[0];
                string password = data[1];
                if (!ContestPasswordMap.ContainsKey(contest))
                    ContestPasswordMap[contest] = password;
            }
            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] data = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contest = data[0];
                string password = data[1];
                string username = data[2];
                int points = int.Parse(data[3]);
                if (ContestPasswordMap.ContainsKey(contest) && ContestPasswordMap[contest] == password)
                {
                    if (!UserContestPointsMap.ContainsKey(username))
                        UserContestPointsMap[username] = new Dictionary<string, int>();
                    if (!UserContestPointsMap[username].ContainsKey(contest))
                        UserContestPointsMap[username][contest] = 0;
                    if (UserContestPointsMap[username][contest] < points)
                        UserContestPointsMap[username][contest] = points;
                }
            }
            string bestCandidate = UserContestPointsMap
                .OrderByDescending(u => u.Value.Values.Sum())
                .First().Key;
            int bestPoints = UserContestPointsMap[bestCandidate].Values.Sum();
            Console.WriteLine($"Best candidate is {bestCandidate} with total {bestPoints} points.");
            Console.WriteLine("Ranking:");
            foreach (var user in UserContestPointsMap.OrderBy(u => u.Key))
            {
                Console.WriteLine(user.Key);
                foreach (var (contest, points) in user.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"#  {contest} -> {points}");
                }
            }

        }
    }
}
