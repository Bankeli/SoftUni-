namespace _04.SoftuniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string>parklotMap = new Dictionary<string, string>();
           
           int commandCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandCount; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                string username = input[1];
               

                switch (command)
                {
                    case "register":
                        string licensPlate = input[2];
                        if (parklotMap.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licensPlate}");
                            continue;
                        }
                        else
                        {
                            parklotMap.Add(username, licensPlate);
                            Console.WriteLine($"{username} registered {licensPlate} successfully");
                        }
                            break;

                    case "unregister":
                        if (!parklotMap.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: user {username} not found");
                            continue;
                        }
                        else
                        {
                            parklotMap.Remove(username);
                            Console.WriteLine($"{username} unregistered successfully");
                        }
                            break;
                }
            }

            foreach ((string user, string licens) in parklotMap)
            {
                Console.WriteLine($"{user} => {licens}");
            }
        }
    }
}
