using System.Text;

namespace _09.SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int commandCount = int.Parse(Console.ReadLine());

            Stack<(int, string)> history = new Stack<(int, string)>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < commandCount; i++)
            {
                string[] input = Console.ReadLine().Split();
                int command = int.Parse(input[0]);

                if (command == 1)
                {
                    string str = input[1];
                    sb.Append(str);
                    history.Push((1, str));
                }

                else if (command == 2)
                {
                    int count = int.Parse(input[1]);
                    string removed = sb.ToString().Substring(sb.Length - count, count);
                    sb.Remove(sb.Length - count, count);
                    history.Push((2, removed));
                }
                else if (command == 3)
                {
                    int index = int.Parse(input[1]);
                    Console.WriteLine(sb[index- 1]);
                }
                else if (command == 4)
                {
                    var last = history.Pop();

                    if (last.Item1 == 1)
                    {
                        int lenght = last.Item2.Length;
                        sb.Remove(sb.Length - lenght, lenght);
                    }
                    else if (last.Item1 == 2)
                    {
                        sb.Append(last.Item2);
                    }
                }
            }
           
                
            
        }
    }
}
