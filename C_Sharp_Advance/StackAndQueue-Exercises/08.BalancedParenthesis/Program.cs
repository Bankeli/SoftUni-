using System.Security.Claims;

namespace _08.BalancedParenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sequence = Console.ReadLine();

            var stack = new Stack<char>();
            bool isValid = true;

            foreach (char symbol in sequence)
            {
                if (symbol == '(' || symbol == '{' || symbol == '[') stack.Push(symbol);
                else
                {

                    if (!stack.Any())
                    {
                        isValid = false;
                        break;
                    }
                    var openingBracket = stack.Pop();

                    if (openingBracket == '{' && symbol == '}') continue;
                    if (openingBracket == '[' && symbol == ']') continue;
                    if (openingBracket == '(' && symbol == ')') continue;

                    isValid = false;
                }
            }
                Console.WriteLine(isValid? "YES" : "NO");
        }
    }
}
