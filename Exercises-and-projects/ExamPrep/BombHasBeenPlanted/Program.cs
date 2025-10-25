using System.ComponentModel.Design;

namespace BombHasBeenPlanted
{
    internal class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            int ctRow = -1;
            int ctCol = -1;

            char[,] playground = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < cols; col++)
                {
                    playground[row, col] = input[col];
                    if (playground[row, col] == 'C')
                    {
                        ctRow = row;
                        ctCol = col;
                    }
                }
            }

            LetsPlay(playground, ctRow, ctCol);
        }
        static void LetsPlay(char[,] field, int ctRow, int ctCol)
        {
            int timer = 16;
            bool isDefused = false;
            bool isDead = false;
            int defuseTime = 3;

            while (timer > 0)
            {
                timer--;
                int lastRow = ctRow;
                int lastCol = ctCol;
                
                string command = Console.ReadLine();

                switch (command)
                {
                    case "up": ctRow--; break;
                    case "down": ctRow++; break;
                    case "left": ctCol--; break;
                    case "right": ctCol++; break;
                    case "defuse":
                        {
                            if (field[ctRow, ctCol] == 'B')
                            {
                                if (timer - defuseTime >= 0)
                                {
                                    timer -= defuseTime;
                                    field[ctRow, ctCol] = 'D';
                                    isDefused = true;

                                    Console.WriteLine("Counter-terrorist wins!");
                                    Console.WriteLine($"Bomb has been defused: {timer} second/s remaining.");
                                }
                                else
                                {
                                    timer -= defuseTime;
                                    field[ctRow, ctCol] = 'X';
                                    
                                }
                            }
                            else timer--;
                        }
                            break;
                }

                if (ctRow < 0 || ctRow >= field.GetLength(0) || ctCol < 0 || ctCol >= field.GetLength(1))
                {
                    ctRow = lastRow;
                    ctCol = lastCol;
                }

                if (field[ctRow, ctCol] == 'T')
                {
                    isDead = true;
                    field[ctRow, ctCol] = '*';
                    Console.WriteLine("Terrorists win!");
                    break;
                }
            }

            if (!isDead && !isDefused)
            {
                Console.WriteLine("Terrorists win!");
                Console.WriteLine("Bomb was not defused successfully!");
                Console.WriteLine($"Time needed: {Math.Abs(timer)} second/s.");
            }

                PrintField(field);
        }
        static void PrintField(char[,] field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write(field[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
