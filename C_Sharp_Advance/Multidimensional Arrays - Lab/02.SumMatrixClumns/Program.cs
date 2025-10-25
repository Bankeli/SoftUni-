
namespace _02.SumMatrixClumns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = input[0];
            int cols = input[1];

            var matrix = ReadMatrix(rows, cols);

            PrintColumnSum(matrix,rows,cols);
        }

        private static void PrintColumnSum(int[,] matrix, int rows, int cols)
        {
            for (int col = 0;  col < cols; col++)
            {
                int sum = 0;
                for (int row = 0; row < rows; row++)
                {
                     sum += matrix[row, col]; 
                }
                Console.WriteLine(sum);
            }
        }

        static int[,] ReadMatrix(int rows, int cols)
        {
            var matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] currRow = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
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
