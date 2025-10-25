namespace Ranking
{
    internal class Program
    {
        class Contest
        {
            public Contest(string name, string pass)
            {
                Name = name;
                Password = pass;
                User = new Dictionary<string, int>();
            }
            public string Name { get; set; }
            public string Password { get; set; }
           public Dictionary<string, int> User { get; set; }

            static void Main(string[] args)
            {
                string input;
                Dictionary<string, Contest> contestMap = new Dictionary<string, Contest>();

                while ((input = Console.ReadLine()) != "end of contests")
                {
                    string[] contestData = input.Split(":");
                    string contestName = contestData[0];
                    string contPass = contestData[1];
                    Contest newContest = new Contest(contestName, contPass);
                    contestMap.Add(contestName, newContest);
                }

                while ((input = Console.ReadLine()) != "end of submissions")
                {
                    string[] arguments = input.Split("=>");
                    string contestName = arguments[0];
                    string contPassword = arguments[1];
                    string username = arguments[2];
                    int points = int.Parse(arguments[3]);

                    if (contestMap.ContainsKey(contestName) && contestMap[contestName].Password == contPassword)
                    {
                        if (!contestMap[contestName].User.ContainsKey(username))
                        {
                            contestMap[contestName].User.Add(username, points);
                        }

                        if (contestMap[contestName].User[username] < points)
                        {
                            contestMap[contestName].User[username] = points;
                        }
                    }
                }
                PrintOrderedUsers(contestMap);
            }

            private static void PrintOrderedUsers(Dictionary<string, Contest> contestMap)
            {
                Dictionary<string, Dictionary<string, int>> users = new();

                foreach (var contest in contestMap.Values)
                {
                    foreach (var kvp in contest.User)
                    {
                        string username = kvp.Key;
                        int points = kvp.Value;

                        if (!users.ContainsKey(username))
                        {
                            users[username] = new Dictionary<string, int>();
                        }

                        users[username][contest.Name] = points;
                    }
                }

                string bestUser = string.Empty;

                int bestPoints = 0;

                foreach (var user in users)
                {
                    int total = user.Value.Values.Sum();
                    if (total > bestPoints)
                    {
                        bestPoints = total;
                        bestUser = user.Key;
                    }
                }

                Console.WriteLine($"Best candidate is {bestUser} with total {bestPoints} points.");
                Console.WriteLine("Ranking:");

                foreach (var user in users.OrderBy(user => user.Key))
                {
                    Console.WriteLine(user.Key);
                    foreach (var contest in user.Value.OrderByDescending(contest => contest.Value))
                    {
                        Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                    }
                }
            }
        }
    }
}
