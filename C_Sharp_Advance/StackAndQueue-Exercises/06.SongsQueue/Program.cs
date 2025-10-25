namespace _06.SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songList = new(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries));

            while (songList.Count > 0)
            {
                string input = Console.ReadLine();

               if (input == "Play") songList.Dequeue();
               else if (input.StartsWith("Add"))
                {
                    string song = input.Substring(4);
                    if (songList.Contains(song)) Console.WriteLine($"{song} is already contained!");
                    else songList.Enqueue(song);
                }
                else if (input == "Show") Console.WriteLine(string.Join(", ", songList));
                
            }

            Console.WriteLine("No more songs!");
        }
    }
}
