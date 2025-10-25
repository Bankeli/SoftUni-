namespace _10.RadioactiveMutantVampireBunnies
{
    internal class Program
    {
        const char Bunny = 'B';
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimensions[0], cols = dimensions[1];

            var lair = new char[rows, cols];
            int playerRow = -1, playerCol = -1; ;
            

            for (int row = 0; row < rows; row++)
            {
                char[] currRow = Console.ReadLine().ToArray();
                for (int col = 0; col < cols; col++)
                {
                    var value = currRow[col];
                    lair[row, col] = value;
                    if (value == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

           var direction = Console.ReadLine().ToArray();

            bool won = false;
            bool dead = false;
            int lastRow = playerRow, lastCol = playerCol;


            foreach (char move in direction)
            {
                lair[playerRow, playerCol] = '.';

                int newRow = playerRow, newCol = playerCol;

                switch (move)
                {
                    case 'U': newRow--; break;
                    case 'D': newRow++; break;
                    case 'L': newCol --; break;
                    case 'R': newCol++; break;

                }
                if (!IsInside(newRow, newCol, rows, cols))
                {
                    won = true;
                    lastRow = playerRow;
                    lastCol = playerCol;
                }
                else
                {
                    playerRow  = newRow;
                    playerCol = newCol;
                    lair[playerRow, playerCol] = 'P';
                }

                List<(int row, int col)> bunnies = new List<(int, int)>();
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (lair[row, col] == 'B')
                        {
                            bunnies.Add((row, col));
                        }
                    }
                }

                foreach (var bunny in bunnies)
                {
                    foreach (var dir in new (int dr, int dc)[] { (-1, 0), (1, 0), (0, -1), (0, 1) })
                    {
                        int br = bunny.row + dir.dr;
                        int bc = bunny.col + dir.dc;

                        if (IsInside(br, bc, rows, cols))
                        {
                            if (lair[br, bc] == 'P')
                            {
                                dead = true;
                                lastRow = br;
                                lastCol = bc;
                            }
                            lair[br, bc] = 'B';
                        }
                    }
                }

                if (won || dead)
                    break;
            }

            PrintLair(lair);

            if (won)
            {
                Console.WriteLine($"won: {lastRow} {lastCol}");
            }
            else if (dead)
            {
                Console.WriteLine($"dead: {lastRow} {lastCol}");
            }

            
        }

        static bool IsInside(int r, int c, int rows, int cols)
        {
            return r >= 0 && r < rows && c >= 0 && c < cols;
        }

        static void PrintLair(char[,] lair)
        {
            for (int r = 0; r < lair.GetLength(0); r++)
            {
                for (int c = 0; c < lair.GetLength(1); c++)
                {
                    Console.Write(lair[r, c]);
                }
                Console.WriteLine();
            }
        }
    }

}

