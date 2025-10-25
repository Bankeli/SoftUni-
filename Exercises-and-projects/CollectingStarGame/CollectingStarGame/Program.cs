using System;

class Program
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int stars = 2; 
        char[,] field = new char[size, size];
        int playerRow = -1;
        int playerCol = -1;

        
        for (int i = 0; i < size; i++)
        {
            var line = Console.ReadLine().Split(' ');
            for (int j = 0; j < size; j++)
            {
                field[i, j] = char.Parse(line[j]);
                if (field[i, j] == 'P')
                {
                    playerRow = i;
                    playerCol = j;
                }
            }
        }

        int currentRow = playerRow;
        int currentCol = playerCol;
        bool firstMoveDone = false;

        while (true)
        {
            string direction = Console.ReadLine();

            int nextRow = currentRow;
            int nextCol = currentCol;

            switch (direction)
            {
                case "up": nextRow--; break;
                case "down": nextRow++; break;
                case "left": nextCol--; break;
                case "right": nextCol++; break;
            }

            
            if (!firstMoveDone)
            {
                field[currentRow, currentCol] = '.';
                firstMoveDone = true;
            }

            
            if (nextRow < 0 || nextRow >= size || nextCol < 0 || nextCol >= size)
            {
                nextRow = 0;
                nextCol = 0;
            }

           
            if (field[nextRow, nextCol] == '#')
            {
                stars--;
                if (stars == 0) break; 
                continue; 
            }

           
            if (field[nextRow, nextCol] == '*')
            {
                stars++;
                field[nextRow, nextCol] = '.'; 
                if (stars == 10) 
                {
                    currentRow = nextRow;
                    currentCol = nextCol;
                    break;
                }
            }

            
            currentRow = nextRow;
            currentCol = nextCol;
        }

        field[currentRow, currentCol] = 'P';

        
        if (stars == 10)
        {
            Console.WriteLine("You won! You have collected 10 stars.");
        }
        else
        {
            Console.WriteLine("Game over! You are out of any stars.");
        }

        Console.WriteLine($"Your final position is [{currentRow}, {currentCol}]");

        
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(field[i, j]);
                if (j < size - 1) Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}

