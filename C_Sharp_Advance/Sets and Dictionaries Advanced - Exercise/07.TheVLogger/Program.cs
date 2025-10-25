namespace _07.TheVLogger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, (HashSet<string> FollowBy, HashSet<string> Following)> UserMap = new();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] data = input.Split();
                if (data[1] == "joined" && data.Length == 4)
                {
                string user = data[0];
                    if (!UserMap.ContainsKey(user))
                    {
                        UserMap[user] = (FollowBy: [], Following: []);
                    }
                }
                else if (data[1] == "followed" && data.Length == 3)
                {
                    string celebrity = data[2];
                    string fan = data[0];
                    if (fan != celebrity && UserMap.ContainsKey(fan) && UserMap.ContainsKey(celebrity))
                    { 
                    UserMap[celebrity].FollowBy.Add(fan);
                    UserMap[fan].Following.Add(celebrity);
                    }
                }
            }

            UserMap = UserMap.OrderByDescending(u => u.Value.FollowBy.Count).ThenBy(u => u.Value.Following.Count).ToDictionary();

            Console.WriteLine($"The V-Logger has a total of {UserMap.Count} vloggers in its logs.");
            int counter = 1;
            foreach ((string vlogger, (HashSet<string> followBy, HashSet<string> following)) in UserMap)
            {
                Console.WriteLine($"{counter}. {vlogger} : {followBy.Count} followers, {following.Count} following");

                if (counter == 1)
                    foreach (var user in followBy.Order())
                    {
                        Console.WriteLine($"*  {user}");
                    }
                counter++;
            }
        }
    }
}
