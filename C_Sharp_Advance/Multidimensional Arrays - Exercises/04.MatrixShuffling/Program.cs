using System.Globalization;

namespace _04.MatrixShuffling;

class Program
{
    static void Main(string[] args)
    {
        var dimensions = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
        int rows = int.Parse(dimensions[0]), cols = int.Parse(dimensions[1]);
         var matrix = ReadMatrix(rows, cols);
        
         string input = string.Empty;
         while ((input = Console.ReadLine()) != "END")
         {
             string[]tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
             string command = tokens[0];
             if (command != "swap" || tokens.Length != 5)
             {
                 Console.WriteLine("Invalid input!");
                 continue;
             }
             int row1 = int.Parse(tokens[1]), col1 = int.Parse(tokens[2]);
             int row2 = int.Parse(tokens[3]), col2 = int.Parse(tokens[4]);
             if (row1 < 0 || row1 >= rows || row2 < 0 || row2 >= rows || col1 < 0 || col1 >= cols || col2 < 0 ||
                 col2 >= cols)
             {
                 Console.WriteLine("Invalid input!");
                 continue;
             }
             
             matrix = SwapMatrix(matrix, row1, col1, row2, col2);
             
             PrintMatrix(matrix, rows, cols);

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

    static void PrintMatrix(int[,] matrix, int rows, int cols)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (j > 0 ) Console.Write(' ');
                Console.Write(matrix[i,j]);
            }

            Console.WriteLine();
        }
        
    }

    static int[,] SwapMatrix(int[,] matrix, int row1, int col1, int row2, int col2)
    {
        int firstLocation = matrix[row1, col1];
        int currentLocation = firstLocation;
        
        matrix[row1, col1] = matrix[row2, col2];
        matrix[row2, col2] = currentLocation;
        
        return matrix;
    }
}