namespace _06.JaggedArrayManipulator;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[][] jaggedArr = new int[n][];

        for (int i = 0; i < n; i++)
        {
            int[] numbers = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

            jaggedArr[i] = numbers;
            for (int j = 0; j < jaggedArr[i].Length; j++)
            {
                jaggedArr[i][j] = numbers[j];
            }
        }

        for (int row = 0; row < jaggedArr.Length - 1 ; row++)
        {
            if (jaggedArr[row].Length == jaggedArr[row + 1].Length)
            {
                jaggedArr[row] = jaggedArr[row].Select(num => num * 2).ToArray();
                jaggedArr[row + 1] = jaggedArr[row + 1].Select(num => num * 2).ToArray();
            }
            else
            {
                jaggedArr[row] = jaggedArr[row].Select(num => num / 2).ToArray();
                jaggedArr[row + 1] = jaggedArr[row + 1].Select(num => num / 2).ToArray();
            }
        }

        string input = string.Empty;

        while ((input = Console.ReadLine()) != "End")
        {
            string[] data = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string action = data[0];
            int row = int.Parse(data[1]);
            int col = int.Parse(data[2]);
            int value = int.Parse(data[3]);

            if (row >= 0 && row < n && col >= 0 && col < jaggedArr[row].Length)
            {
                if (action == "Add")
                {
                    jaggedArr[row][col] += value;
                }
                else if (action == "Subtract")
                {
                    jaggedArr[row][col] -= value; 
                }
            }
        }

        for (int row = 0; row < n; row++)
        {
            Console.WriteLine(string.Join(" ", jaggedArr[row]));
        }
    }
}