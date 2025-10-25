
namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string passwor = Console.ReadLine();
            bool passwordLenghtCheck = CheckPassworLenght(passwor);
            if (!passwordLenghtCheck)
                Console.WriteLine("Password must be between 6 and 10 characters");
            bool specialSymbolCheck = CheckForSpecialSymbols(passwor);
            if (!specialSymbolCheck)
                Console.WriteLine("Password must consist only of letters and digits");
            bool twoDigitChecker = CheckForAtLeastTwoDigits(passwor);
            if (!twoDigitChecker)
                Console.WriteLine("Password must have at least 2 digits");

            if (twoDigitChecker && passwordLenghtCheck && specialSymbolCheck)
                Console.WriteLine("Password is valid");
            
        }

         static bool CheckForSpecialSymbols(string text)
        {
            foreach (char c in text)
            {
                if (char.IsDigit(c) || char.IsLetter(c))
                    continue;
                else
                {
                    return false;
                }
            }
            return true;
        }

        static bool CheckPassworLenght(string text)
        {
            if (text.Length >= 6 && text.Length <= 10)
                return true;
            return false;
        }

        static bool CheckForAtLeastTwoDigits(string text)
        {
            int counter = 0;

            for (int i = 0; i < text.Length; i++) 
            {
                char c = text[i];
                if (c >= '0' && c <= '9')
                    counter++;
            }
            if (counter < 2)
                return false;
            return true;
        }
    }
}
