 namespace _05.SnakeMoves;

class Program
{
    static void Main(string[] args)
    {
       int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
       int rows = dimensions[0];
        int cols = dimensions[1];
        
        string snake = Console.ReadLine();
        
        char[,] matrix = new char[rows, cols];
        
        int snakePosition = 0;

        for (int row = 0; row < rows; row++)
        {
            for (int j = 0; j < cols ;j++)
            {
                int col = row % 2 == 0 ? j : cols- (j + 1);
                matrix[row, col] = snake[snakePosition];
                snakePosition =  (snakePosition + 1) % snake.Length;
            }
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j]);
            }

            Console.WriteLine();
        }
    }
}