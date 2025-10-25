namespace Fortress
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] fortress = new char[size, size];
            int spyRow = -1;
            int spyCol = -1;

            for (int i = 0; i < size; i++)
            {
                string line = Console.ReadLine();

                for (int j = 0; j < size; j++)
                {
                    fortress[i, j] = line[j];
                    if (fortress[i, j] == 'S')
                    {
                        spyRow = i;
                        spyCol = j;
                    }
                }
            }
            int stealthPoint = 100;
            string command = string.Empty;
            bool isSpyDead = false;
            bool exitIsReach = false;
            while (stealthPoint > 0 && !exitIsReach)
            {
                fortress[spyRow, spyCol] = '.';
                command = Console.ReadLine();
                int currRow = spyRow;
                int currCol = spyCol;

                switch (command)
                {
                    case "up":
                        currRow--;
                        break;
                    case "down":
                        currRow++;
                        break;
                    case "left":
                        currCol--;
                        break;
                    case "right":
                        currCol++;
                        break;
                }

                if (currRow < 0 || currRow >= size || currCol < 0 || currCol >= size)
                    continue;
                if (fortress[currRow, currCol] == 'G')
                {
                    stealthPoint -= 40;
                    if (stealthPoint <= 0)
                        isSpyDead = true;
                }
                else if (fortress[currRow, currCol] == 'B')
                    stealthPoint = Math.Min(stealthPoint + 15, 100);
                else if (fortress[currRow, currCol] == 'E')
                    exitIsReach = true;

                spyRow = currRow;
                spyCol = currCol;
            }

            if (isSpyDead)
            {
                Console.WriteLine("Mission failed. Spy compromised.");
                fortress[spyRow, spyCol] = 'S';
            }
            else
                Console.WriteLine("Mission accomplished. Spy extracted successfully.");
            Console.WriteLine($"Stealth level: {stealthPoint} units");

            for (int i = 0; i < fortress.GetLength(0); i++)
            {
                for (int j = 0; j < fortress.GetLength(1); j++)
                {
                    Console.Write(fortress[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
