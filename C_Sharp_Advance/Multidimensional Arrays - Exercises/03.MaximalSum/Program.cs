using System.Globalization;

namespace _03.MaximalSum;

class Program
{
    static void Main(string[] args)
    {
        int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int rows = dimensions[0], cols = dimensions[1];
       if (rows < 3 || cols < 3)
           return;  

        var matrix = ReadMatrix(rows, cols);

        int maxSum = int.MinValue;
        int maxRow = -1, maxCol = -1;
        for (int i = 0; i < rows - 2; i++)
        {
            for (int j = 0; j < cols - 2; j++)
            {
                int currentSum = SquareMatrixSum(matrix, i, j, 3, 3);
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxRow = i;
                    maxCol = j;
                }
            }
        }

        Console.WriteLine($"Sum = {maxSum}");
        PrintSubmatrix(matrix, maxRow, maxCol, 3 , 3);
    }

     static void PrintSubmatrix(int[,] matrix, int maxRow, int maxCol, int height, int width)
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (j > 0 ) Console.Write(' ');
                Console.Write(matrix[maxRow + i, maxCol + j]);
            }

            Console.WriteLine();
        }
    }

    static int[,] ReadMatrix(int rows, int cols)
    {
        var matrix = new int[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            int[] currRow = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int col = 0; col < cols; col++)
            {
                var value = currRow[col];
                matrix[row, col] = value;
            }
        }

        return matrix;
    }

    static int SquareMatrixSum(int[,] matrix, int row, int col, int height , int width)
    {
        int sum = 0;
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                sum += matrix[row + i, col + j];
            }
        }

        return sum;
    }
}