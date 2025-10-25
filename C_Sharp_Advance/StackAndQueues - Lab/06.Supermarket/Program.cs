namespace _06.Supermarket
/*

Liam
Noah
James
Paid
Oliver
Lucas
Logan
Tiana
End
 */
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Queue<string> queue = new Queue<string>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                if (input == "Paid")
                {
                    foreach (var customer in queue)
                    {
                        Console.WriteLine(customer);
                    }
                    queue.Clear();
                }
                else
                {
                    queue.Enqueue(input);
                }
            }

            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
