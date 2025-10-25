int size = int.Parse(Console.ReadLine());

var matrix = ReadMatrix(size,size);

var primarySum = 0;

for (int i = 0; i < size ; i++)
{
    primarySum += matrix[i,i];
}
int secondarySum = 0;
for (int i = 0; i < size; i++)
{
    secondarySum += matrix[i, size - i - 1] ;
}

Console.WriteLine(Math.Abs(primarySum - secondarySum));

static int[,] ReadMatrix (int rows, int cols)
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