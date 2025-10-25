namespace MusicLibrary
{
    public class Track
    {
        public Track(string title, string artist, int duration, string genre)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            Genre = genre;
        }

        public string Title { get; }
        public string Artist { get; }
        public int Duration { get; }
        public string Genre { get; }

        public override string ToString()
        => $"Track: '{Title}' by {Artist} - {Duration}s [{Genre}]";
    }
}
