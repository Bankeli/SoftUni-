

namespace Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> friendList = Console.ReadLine().Split(", ").ToList();
            string input = string.Empty;
            int blacklistCounter = 0;
            int lostCounter = 0;

            while ((input = Console.ReadLine()) != "Report")
            {
                string[] arguments = input.Split();
                int index = 0;

                switch (arguments[0])
                {
                    case "Blacklist":
                        string name = arguments[1];
                        if (friendList.Contains(name))
                        {
                             index = friendList.IndexOf(name);
                            friendList[index] = "Blacklisted";
                            Console.WriteLine($"{name} was blacklisted.");
                            blacklistCounter++;
                        }
                        else
                        {
                            Console.WriteLine($"{name} was not found.");
                        }

                            break;

                    case "Error":
                       index = int.Parse(arguments[1]);

                        if (index < 0 || index > friendList.Count -1 || friendList[index] == "Blacklisted" || friendList[index] == "Lost")
                            continue;

                        else
                        {
                            string currName = friendList[index];
                            friendList[index] = "Lost";
                            Console.WriteLine($"{currName} was lost due to an error.");
                            lostCounter++;
                        }

                            break;

                    case "Change":
                        index = int.Parse(arguments[1]);
                        string newName = arguments[2];

                        if (index< 0 || index > friendList.Count - 1 )
                        {
                            continue;
                        }
                        else
                        {
                            string currName = friendList[index];
                            friendList[index] = newName;
                            Console.WriteLine($"{currName} changed his username to {newName}.");
                        }
                        break;
                }
            }

            Console.WriteLine($"Blacklisted names: {blacklistCounter}");
            Console.WriteLine($"Lost names: {lostCounter}");
            Console.WriteLine(string.Join(" ",friendList));
        }
    }
}
