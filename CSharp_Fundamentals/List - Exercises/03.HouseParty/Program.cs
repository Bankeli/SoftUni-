namespace _03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCommands = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < numberCommands; i++)
            {
                string[] commands = Console.ReadLine().Split();
                string name = commands[0];

                if (commands[2] != "not")
                {
                    if (!guests.Contains(name))
                    {
                        guests.Add(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                }
                else
                {
                    if (guests.Contains(name))
                    {
                        guests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }
            foreach (string guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
