namespace _03.SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           Stack<string> stack = new Stack <string>(Console.ReadLine().Split().Reverse());

            int result = int.Parse(stack.Pop());


            while (stack.Count>0)
            {
               string op  = stack.Pop();
                int number = int.Parse(stack.Pop());

                if (op == "+")
                {
                    result += number;
                }
                else if (op == "-")
                {
                    result -= number;
                }
            }
            Console.WriteLine(result);
        }
    }
}
