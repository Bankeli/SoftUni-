namespace BasicSyntax_MoreExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyBalance = double.Parse(Console.ReadLine());
            string command;
            double gameSum = 0;
            Dictionary<string, double> games = new Dictionary<string, double>
{
    { "OutFall 4", 39.99 },
    { "CS: OG", 15.99 },
    { "Zplinter Zell", 19.99 },
    { "Honored 2", 59.99 },
    { "RoverWatch", 29.99 },
    {"RoverWatch Origins Edition", 39.99 }
};

            while ((command = Console.ReadLine()) != "Game Time")
            {
                if (!games.ContainsKey(command))
                    {
                    Console.WriteLine("Not Found");
                    continue;
                }

                double price = games[command];
                if (moneyBalance >= price)
                {
                    Console.WriteLine($"Bought {command}");
                    moneyBalance -= price;
                    gameSum += price;
                }
                else
                    Console.WriteLine("Too Expensive");
                if (moneyBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return ;
                }
                    

            }
            Console.WriteLine($"Total spent: ${gameSum:f2}. Remaining: ${moneyBalance:f2}");
        }
    }
}
