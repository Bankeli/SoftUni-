namespace Registration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Registration")
            {
                string[] arguments = command.Split();

                switch (arguments[0])
                {
                    case "Letters":
                        if (arguments[1] == "Lower")
                        {
                            username = username.ToLower();
                            
                        }
                        else if (arguments[1] == "Upper")
                        {
                            username = username.ToUpper();
                        }
                            Console.WriteLine(username);
                            break;

                    case "Reverse":
                        int startIndex = int.Parse(arguments[1]);
                        int endIndex = int.Parse(arguments[2]);
                        List<string> shortString = new();
                        if (startIndex < 0 && startIndex > username.Length - 1 || endIndex > username.Length - 1 && endIndex < 0)
                        {
                            continue;
                        }
                        else
                            for (int i = username[startIndex]; i <= username[endIndex]; i++)
                            {
                                shortString.Add(username[i]);
                            }  
                            
                        break;


                }
            }
        }
    }
}
