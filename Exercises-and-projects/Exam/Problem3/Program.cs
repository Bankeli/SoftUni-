namespace Problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> chatLogger = new List<string>();
            string command = string.Empty;
            int index = 0;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split();
            string messages = string.Empty;

                switch (arguments[0])
                {
                    case "Chat":
                        chatLogger.Add(arguments[1]);
                        break;

                    case "Delete":
                        if (chatLogger.Contains(arguments[1]))
                            chatLogger.Remove(arguments[1]);
                        else
                            continue;
                            break;

                    case "Edit":
                        messages = arguments[1];
                        string editedVersion = arguments[2];

                        if (chatLogger.Contains(messages))
                        {
                             index = chatLogger.IndexOf(messages);
                            chatLogger[index] = editedVersion;
                        }
                        else
                            continue;
                            break;

                    case "Pin":
                        string currMessage = string.Empty;
                        messages = arguments[1];
                        if (chatLogger.Contains(messages))
                        {
                            index = chatLogger.IndexOf(messages);
                            currMessage = chatLogger[index];
                            chatLogger.RemoveAt(index);
                            chatLogger.Add(currMessage);
                        }
                        else 
                            continue ;
                            break;

                    case "Spam":

                        for (int i = 1;i < arguments.Length; i++)
                        {
                            chatLogger.Add(arguments[i]);
                        }
                        break;
                }

            }

            Console.WriteLine(string.Join("\n",chatLogger));
        }
    }
}
