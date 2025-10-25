namespace _03.PrimaryDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int rows = size;
            int cols = size;
            var matrix = ReadMatrix(rows, cols);

            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                sum += matrix[i, i];
            }
            Console.WriteLine(sum);
        }

        static int[,] ReadMatrix(int rows, int cols)
        {
            var matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] currRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
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
