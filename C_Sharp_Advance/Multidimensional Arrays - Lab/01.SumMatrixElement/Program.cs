using System.Threading.Channels;

namespace _01.SumMatrixElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = input[0];
            int cols = input[1];

            var matrix = ReadMatrix(rows, cols);
            Console.WriteLine(rows);
            Console.WriteLine(cols);
            PrintMatrixSum(matrix);
            
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

        static void PrintMatrixSum(int[,] matrix)
        {
            int matrixSum = 0;
            foreach (var element in matrix)
            {
                matrixSum += element;
            }
            Console.WriteLine(matrixSum);
        }

    }
}
