namespace _03.Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            var songList = new List<Songs>();

            for (int i = 0; i < number; i++)
            {
                string[] arguments = Console.ReadLine().Split("_");

                string type = arguments[0];
                string title = arguments[1];
                string time = arguments[2];

                Songs song = new Songs();

                song.TypeList = type;
                song.Title = title;
                song.Time = time;

                songList.Add(song);
            }
            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (var song in songList)
                {
                    Console.WriteLine(song.Title);
                }
            }
            else
            {
                foreach (var song in songList)
                {
                    if (song.TypeList == typeList)
                        Console.WriteLine(song.Title);

                }
            }
        }
    }
    public class Songs
    {
        public string TypeList { get; set; }
        public string Title { get; set; }
        public string Time { get; set; }
    }
}
