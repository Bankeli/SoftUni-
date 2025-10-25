namespace ShoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine().Split("!").ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Go Shopping!")
            {
                string[] arguments = command.Split();
                string item = string.Empty;
                switch (arguments[0])
                {
                    case "Urgent":
                         item = arguments[1];
                        if (shoppingList.Contains(item))
                        { 
                            continue;
                        }
                        else
                        {
                            shoppingList.Insert(0,item);
                        }
                            break;

                    case "Unnecessary":
                        item = arguments[1];
                        if (shoppingList.Contains(item))
                        {
                            shoppingList.Remove(item);
                        }
                        else
                            continue;
                            break;

                    case "Correct":
                        string oldItem = arguments[1];
                        string newItem = arguments[2];
                        
                       int itemIndex = shoppingList.IndexOf(oldItem);
                        if (itemIndex != -1)
                        {
                            shoppingList[itemIndex] = newItem;
                        }
                           
                        break;

                    case "Rearrange":
                        item = arguments[1];
                        if (shoppingList.Contains(item))
                        {
                            shoppingList.Remove(item);
                            shoppingList.Add(item);
                        }
                        else
                            continue;

                            break;
                }
            }

            Console.WriteLine(string.Join (", ",shoppingList));
        }
    }
}
