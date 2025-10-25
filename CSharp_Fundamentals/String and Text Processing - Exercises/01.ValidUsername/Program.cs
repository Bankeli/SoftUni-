namespace _01.ValidUsername
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (string username in usernames)
            {
                if (username.Length <3 ||  username.Length > 16)
                {
                    continue;
                }

                bool isValidUser = username.All(character => char.IsLetterOrDigit(character) || character == '-' || character == '_' );
               

                if (isValidUser)
                {
                    Console.WriteLine(username);
                }
            }
        }
    }
}
