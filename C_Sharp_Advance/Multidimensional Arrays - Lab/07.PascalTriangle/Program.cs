using System.Runtime.Serialization.Formatters;

namespace _07.PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            long[][] PascalTriangle = new long[size][];

            PascalTriangle[0] = new long[] { 1};
            if (size > 1)
            {

                PascalTriangle[1] = new long[] {1, 1 };

                for (int row = 2; row < size; row++)
                {
                    var colSize = row + 1;
                    PascalTriangle[row] = new long[colSize];
                    PascalTriangle[row][0] = 1;
                    PascalTriangle[row][colSize - 1] = 1;

                    for (int col = 1; col < colSize - 1; col++)
                    {
                        long value = PascalTriangle[row - 1][col] + PascalTriangle[row - 1][col - 1];

                        PascalTriangle[row][col] = value;
                    }
                }
            }
            for (int row = 0; row < size; row++)
            {
                Console.WriteLine(string.Join(" ", PascalTriangle[row]));
            }
        }
    }
}
