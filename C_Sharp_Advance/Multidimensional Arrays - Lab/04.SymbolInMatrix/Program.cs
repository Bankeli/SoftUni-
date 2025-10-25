namespace _04.SymbolInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int rows = matrixSize;
            int cols = matrixSize;

            var matrix = ReadMatrix(rows, cols);
            char symbol = char.Parse(Console.ReadLine());
            bool isFound = false;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (symbol == matrix[row, col])
                    {
                        Console.WriteLine($"({row}, {col})");
                        isFound = true;
                        return;
                    }
                }
            }  
           if ( !isFound ) Console.WriteLine($"{symbol} does not occur in the matrix");

        }
        static char[,] ReadMatrix(int rows, int cols)
        {
            var matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string currRow = Console.ReadLine();
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
