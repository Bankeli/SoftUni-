namespace ToDoList;

class Program

{
    private static void MenuMessage()
    {
        Console.WriteLine("To add new task press: 1");
        Console.WriteLine("To chek your task list press: 2");
        Console.WriteLine("Delete current task press: 3");
        Console.WriteLine("Exit press: 4");
    }

    static void AddTask(List<string> todoList)
    {
        Console.WriteLine("What is your task?");
        string input = Console.ReadLine();
        string existingInput = todoList.FirstOrDefault(str => str == input);

        if (existingInput == null)
        {
            Console.WriteLine("Task is added!");
            todoList.Add(input);
        }
        else
        {
            Console.WriteLine("This task already exists!");
            return;
        }
    }

    static void PrintTheTaskList(List<string> todoList)
    {

        if (todoList.Count == 0)
        {
            Console.WriteLine("List is empty!");
            return;
        }
        for (int i = 0; i < todoList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {todoList[i]}");
        }
    }

    static void DeleteTask(List<string> todoList)
    {
        if (todoList.Count == 0)
        {
            Console.WriteLine("No tasks to delete.");
            return;
        }

        PrintTheTaskList(todoList);
        Console.Write("Enter the number of the task to delete: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= todoList.Count)
        {
            Console.WriteLine($"Task \"{todoList[index - 1]}\" deleted.");
            todoList.RemoveAt(index - 1);
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
    }

    static void Main(string[] args)
    {
        List<string> todoList = new();
        string input;
        Console.WriteLine("Hello this is your to do list!");
        Console.WriteLine();

        do
        {
            MenuMessage();
            Console.Write("Please select option: ");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    AddTask(todoList);
                    break;
                case "2":
                    PrintTheTaskList(todoList);
                    break;
                case "3":
                    DeleteTask(todoList);
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

            Console.WriteLine();
        } while (input != "4");
    }
}