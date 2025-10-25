namespace FishingCompetition

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            string[,] fishingArea = new string[size, size];
            int currentRow = -1;
            int currentCol = -1;
            int quota = 20;

            for (int row = 0; row < size; row++)
            {
                string newRow = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    fishingArea[row, col] = newRow[col].ToString();

                    if (fishingArea[row, col] == "S")
                    {
                        currentRow = row;
                        currentCol = col;
                    }
                }
            }

            string command = string.Empty;

            int totalCatch = 0;
            int nextRow = currentRow;
            int nextCol = currentCol;
            bool firstMoveDone = false;
            

            while ((command = Console.ReadLine()) != "collect the nets")
            {
                if (!firstMoveDone)
                {
                    fishingArea[nextRow, nextCol] = "-";
                    firstMoveDone = true;
                }
                switch (command)
                {
                    case "up": nextRow--; break;
                    case "down": nextRow++; break;
                    case "left": nextCol--; break;
                    case "right": nextCol++; break;
                }

                if (command == "up" || command == "down")
                {
                    if (nextRow < 0)
                    {
                        nextRow = size - 1;
                    }
                    else if (nextRow >= size)
                    {
                        nextRow = 0;
                    }
                }

                if (command == "left" || command == "right")
                {
                    if (nextCol < 0)
                    {
                        nextCol = size - 1;
                    }
                    else if (nextCol >= size)
                    {
                        nextCol = 0;
                    }
                }

                if (fishingArea[nextRow, nextCol] == "W")
                {
                    currentRow = nextRow;
                    currentCol = nextCol;
                    Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{currentRow},{currentCol}]");
                    Environment.Exit(0);
                }
                else if (Char.IsDigit(fishingArea[nextRow, nextCol][0]))
                {
                    totalCatch += int.Parse(fishingArea[nextRow, nextCol]);
                    fishingArea[nextRow, nextCol] = "-";
                    currentRow = nextRow;
                    currentCol = nextCol;
                }
                currentRow = nextRow;
                currentCol = nextCol;

            }
            fishingArea[currentRow,currentCol] = "S";

            if (totalCatch >= 20)
            {
                Console.WriteLine($"Success! You managed to reach the quota!");
            }
            else
            {
                Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {20 - totalCatch} tons of fish more.");
            }

            if (totalCatch > 0)
            {
                Console.WriteLine($"Amount of fish caught: {totalCatch} tons.");
            }


            for (int i = 0; i < fishingArea.GetLength(0); i++)
            {
                for (int j = 0; j < fishingArea.GetLength(1); j++)
                {
                    Console.Write(fishingArea[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
