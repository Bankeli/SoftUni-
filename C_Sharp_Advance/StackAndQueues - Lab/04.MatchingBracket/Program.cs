using System.Security.Claims;

namespace _04.MatchingBracket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression  = Console.ReadLine();

            var stack = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                var symbol = expression[i];

                if (symbol == '(')
                {
                    stack.Push(i);
                }
                else if (symbol == ')')
                {
                    int openingBracketIndex = stack.Pop();
                    int closingBracketIndex = i;

                    var result = expression.Substring(openingBracketIndex, closingBracketIndex - openingBracketIndex + 1);

                    Console.WriteLine(result);
                }
                        
            }
        }
    }
}
