namespace _09.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());
                int result = GetMax(number1, number2);
                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                char symbol1 = char.Parse(Console.ReadLine());
                char symbol2 = char.Parse(Console.ReadLine());
                char result = GetMax(symbol1, symbol2);
                Console.WriteLine(result);
            }
            else if (type == "string")
            {
                string str1 = Console.ReadLine();
                string str2 = Console.ReadLine();
                string result = GetMax(str1, str2);
                Console.WriteLine(result);
            }

            
           
        }

        static int GetMax(int num1, int num2)
        {
            
            if (num1 > num2)
                return num1;
            else
                return num2;
        }    

        static char GetMax(char symbol1, char symbol2)
        {
            if (symbol1 > symbol2) return symbol1;
            else return symbol2;
        }

        static string GetMax(string str, string str2)
        {
            if (str.CompareTo(str2) == 1)
                return str;

            return str2;

        }
    }
}
