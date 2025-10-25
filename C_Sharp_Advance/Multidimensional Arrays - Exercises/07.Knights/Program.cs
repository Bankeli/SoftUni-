namespace _07.Knights;

class Program
{
    const char Knight = 'K';

    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());
        char[][] board = new char[size][];

        for (int i = 0; i < size; i++)
        {
            string input = Console.ReadLine();
            board[i] = new char[size];
            for (int j = 0; j < size; j++)
            {
                board[i][j] = input[j];
            }
        }

        int conflictsCounter = 0;

        while (ReolveConflict(board)) conflictsCounter++;
        
        Console.WriteLine(conflictsCounter);
       
    }

    static bool ReolveConflict(char[][] board)
    {
        int maxConflict = 0, maxrow = -1, maxcol = -1;
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                if (board[i][j] != Knight) continue;

                int currentConflict = ConflictCounter(board, i, j);
                
                if (currentConflict > maxConflict)
                {
                maxConflict = currentConflict;
                maxrow = i;
                maxcol = j;
                }
            }
            
        }
            if (maxConflict == 0) return false;
            board[maxrow][maxcol] = '0';
            return true;
    }

    static int ConflictCounter(char[][] board, int row, int col)
    {
        return CheckForConflict(board, row - 2, col - 1) + CheckForConflict(board, row - 2, col + 1) 
                                                           + CheckForConflict(board, row + 2, col - 1) + CheckForConflict(board, row + 2, col + 1) 
                                                         + CheckForConflict(board, row - 1, col - 2) + CheckForConflict(board, row - 1, col + 2)
                                                         + CheckForConflict(board, row +1, col - 2) + CheckForConflict(board, row + 1, col + 2);
    }

    static int CheckForConflict(char[][] board, int row, int col)
    {
        if (row >= 0 && row < board.Length && col >= 0 && col < board[row].Length &&
            board[row][col] == Knight) return 1;
        return 0;
    }
}