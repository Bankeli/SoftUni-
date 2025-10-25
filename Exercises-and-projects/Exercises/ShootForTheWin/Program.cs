namespace ShootForTheWin
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = string.Empty;
            int shotCounter = 0;

            while ((input = Console.ReadLine()) != "End")
            {
                int index = int.Parse(input);

                if (index < 0 || index > targets.Count - 1)
                    continue;

                int currentNumber = targets[index];

                if (currentNumber == -1)
                    continue;
                else
                    targets[index] = -1;

                shotCounter++;

                for (int i = 0; i < targets.Count; i++)
                {
                    if (targets[i] == -1)
                        continue;
                    else if (currentNumber < targets[i] )
                    {
                        targets[i] -= currentNumber;
                    }
                    else if (currentNumber >= targets[i])
                        targets[i] += currentNumber;
                }
            }

            Console.WriteLine($"Shot targets: {shotCounter} -> {string.Join(" ",targets)}");
        }
    }
}
