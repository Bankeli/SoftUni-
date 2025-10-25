
namespace _06.JaggedArrayModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                var currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();

                jaggedArray[i] = currentRow;
            }
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                int row, col, value;

                ExtractData(input, out row, out col, out value);

                if (ValidCoordinate(jaggedArray,row, col))
                {
                    if (input.StartsWith("Add"))
                    {
                        jaggedArray[row][col] += value;
                    }
                    else if (input.StartsWith("Subtract"))
                    {
                        jaggedArray[row][col] -= value;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
            }
            PrintJaggedArray(jaggedArray);
        }

        private static void PrintJaggedArray(int[][] jaggedArray)
        {
            for (int i = 0;i < jaggedArray.Length;i++)
            {
                Console.WriteLine(string.Join(" ", jaggedArray[i]));
            }
        }

        private static void ExtractData(string input, out int row, out int col, out int value)
        {
            string[] data = input.Split();
            row = int.Parse(data[1]);
            col = int.Parse(data[2]);
            value = int.Parse(data[3]);
        }

        static bool ValidCoordinate(int[][] jaggedArray, int row, int col)
        {
            if (row < 0 || row >= jaggedArray.Length)
            {  return false; }

            if (col<0  || col >= jaggedArray[row].Length)
                { return false; }

            return true;
        }
    }
}
