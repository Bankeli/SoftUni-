namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;
            int attempts = 1;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                char currentCharacter = username[i];
                password += currentCharacter;
            }

            while (true)
            {
                string inputPassword = Console.ReadLine();
                if (inputPassword == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else if (attempts > 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    attempts++;
                }

               



            }

        }
    }
}
