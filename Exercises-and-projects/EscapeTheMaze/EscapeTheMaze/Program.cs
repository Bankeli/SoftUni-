int size = int.Parse(Console.ReadLine());

var maze = new char[size,size];

int health = 100;

var playerRow = -1;
var playerCol = -1;
bool isFirstMove = false;

for (int i = 0; i < size; i++)
{
    string lines = Console.ReadLine();
        
    for (int j = 0; j < size; j++)
    {
        maze[i, j] = lines[j];

        if (maze[i, j] == 'P')
        {
            playerRow = i;
            playerCol = j;
        }
    }
}
    int nextRow = playerRow;
    int nextCol = playerCol;

while (true)
{
    string direction = Console.ReadLine();
    switch (direction)
    {
        case "up":
            nextRow--;
            break;
        case "down":
            nextRow++;
            break;
        case "left":
            nextCol--;
            break;
        case "right":
            nextCol++;
            break;
            
    }
    if (nextRow < 0 || nextRow >= size || nextCol < 0 || nextCol >= size)
    {
        nextRow = playerRow;
        nextCol = playerCol;
        continue;
    }

    if (!isFirstMove)
    {
        maze[playerRow, playerCol] = '-';
        isFirstMove = true;
    }

    if (maze[nextRow, nextCol] == 'M')
    {
        health -= 40;
        if (health > 0)
        {
            playerRow = nextRow;
            playerCol = nextCol;
            maze[playerRow, playerCol] = '-';
        }
        else if (health <= 0)
        {
            health = 0;
            Console.WriteLine("Player is dead. Maze over!");
            playerRow = nextRow;
            playerCol = nextCol;
            break;
        }
    }
    else if (maze[nextRow, nextCol] == 'H')
    {
        health += 15;
        if (health > 100)
            health = 100;

        maze[nextRow, nextCol] = '-';

        playerRow = nextRow;
        playerCol = nextCol;
    }

    else if (maze[nextRow, nextCol] == 'X')
    {
        playerRow = nextRow;
        playerCol = nextCol;
        Console.WriteLine("Player escaped the maze. Danger passed!");
        break;
    }
    else
    {
        playerRow = nextRow;
        playerCol = nextCol;
    }
}
maze[playerRow, playerCol] = 'P';

Console.WriteLine($"Player's health: {health} units");

for (int i = 0; i < maze.GetLength(0); i++)
{
    for (int j = 0; j < maze.GetLength(1); j++)
    {
        Console.Write(maze[i,j]);
    }
    Console.WriteLine();
}