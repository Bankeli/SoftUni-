
using System.Text;

namespace PasswordReset
{
    internal class Program
    {
       public static string Password { get; set; }
        static void Main(string[] args)
        {
             Password = Console.ReadLine();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Done")
            {
                string[] arguments = input.Split();

                string action = arguments[0];

                switch (action)
                {
                    case "TakeOdd":
                        TakeOddIndexes(Password);
                        break;

                    case "Cut":
                        Cut(int.Parse(arguments[1]), int.Parse(arguments[2]));
                        break;

                    case "Substitute":
                        Substitute(arguments[1], arguments[2]);
                        break;
                }
            }

            Console.WriteLine($"Your password is: {Password}");
        }


        private static void TakeOddIndexes(string password)
        {
            StringBuilder sb= new StringBuilder();

            for (int i = 1; i < password.Length; i++)
            {
                if ( i % 2 != 0)
                {
                    sb.Append(password[i]);
                }
            }
            string filteredPass = sb.ToString();
            Password = filteredPass;

            Console.WriteLine(filteredPass);
        }
        private static void Cut(int index, int lenght)
        {
            Password = Password.Remove(index, lenght);
            Console.WriteLine(Password);
        }
        private static void Substitute(string substring, string replacement)
        {
            if (Password.Contains(substring))
            {
                Password = Password.Replace(substring, replacement);

                Console.WriteLine(Password);
            }
            else
            {
                Console.WriteLine("Nothing to replace!");
            }
        }
    }
}
