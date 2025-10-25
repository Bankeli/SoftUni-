namespace _05.SquareWithMaximumSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = input[0];
            int cols = input[1];
            var matrix = ReadMatrix(rows, cols);
            int biggestSum = 0;
            int biggestRow = 0;
            int biggestCol = 0;


            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    int currSum = matrix[row, col] + matrix[row, col+1] + matrix[row + 1, col] + matrix[row+1,col+1];
                    if (currSum > biggestSum)
                    {
                        biggestSum = currSum;
                        biggestRow = row;
                        biggestCol = col;
                    }
                }
            }
            Console.WriteLine($"{matrix[biggestRow,biggestCol]} {matrix[biggestRow, biggestCol+1]}");
            Console.WriteLine($"{matrix[biggestRow+1, biggestCol]} {matrix[biggestRow+1, biggestCol + 1]}");
            Console.WriteLine(biggestSum);
        }

        static int[,] ReadMatrix(int rows, int cols)
        {
            var matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] currRow = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    var value = currRow[col];
                    matrix[row, col] = value;
                }
            }

            return matrix;
        }
    }
}
