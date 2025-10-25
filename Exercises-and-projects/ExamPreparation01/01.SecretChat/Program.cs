namespace _01.SecretChat
{
    internal class Program
    {
        public static string ConcealedMessage = string.Empty;
        static void Main(string[] args)
        {
             ConcealedMessage = Console.ReadLine();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Reveal")
            {
                string[] arguments = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string action = arguments[0];

                switch (action)
                {
                    case "InsertSpace":
                        InsertSpace(int.Parse(arguments[1]));
                        break;

                    case "Reverse":
                        ReverseSubstring(arguments[1]);
                        break ;

                    case "ChangeAll":
                        ChangeAll(arguments[1], arguments[2]);
                        break ;
                }
            }

            Console.WriteLine($"You have a new text message: {ConcealedMessage}");
        }

        private static void ChangeAll(string substring, string replacement)
        {
           ConcealedMessage = ConcealedMessage.Replace(substring, replacement);

            Console.WriteLine(ConcealedMessage);
        }

        private static void ReverseSubstring(string substring)
        {
            if (ConcealedMessage.Contains(substring))
            {
               int index = ConcealedMessage.IndexOf(substring);
                string beforSubstring = ConcealedMessage.Substring(0, index);
                string afterSubstring = ConcealedMessage.Substring(index + substring.Length);
                string reversedString = new string (substring.Reverse().ToArray());

                ConcealedMessage = beforSubstring + afterSubstring + reversedString;

                Console.WriteLine(ConcealedMessage);
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        private static void InsertSpace(int index)
        {
            ConcealedMessage = ConcealedMessage.Insert(index, " ");
            Console.WriteLine(ConcealedMessage);
        }
    }
}
