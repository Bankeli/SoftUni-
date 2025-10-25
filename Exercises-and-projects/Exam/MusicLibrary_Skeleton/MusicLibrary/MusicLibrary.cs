using System.Text;

namespace MusicLibrary
{
    public class MusicLibrary
    {
        public MusicLibrary(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Tracks = new List<Track>();
        }

        public string Name { get;}
        public int Capacity { get; set; }
        public List<Track> Tracks { get; set; }

        public void AddTrack(Track track)
        {
            if (Tracks.Count >= Capacity) return;

            bool duplicateExist = Tracks.Any(t => t.Title == track.Title && t.Artist == track.Artist);

            if (duplicateExist) return;

            Tracks.Add(track);
        }

        public bool RemoveTrack(string title, string artist) 
        {
            var foundedTrack = Tracks.FirstOrDefault(t => t.Title == title && t.Artist == artist);
            if (foundedTrack != null)
            {
                Tracks.Remove(foundedTrack);
                return true;
            }
            return false;
        }

        public Track GetLongestTrack()
        {
            return Tracks.OrderByDescending(a => a.Duration).FirstOrDefault();
        }

        public string GetTrackDetails(string title, string artist)
        {
            var track = Tracks.FirstOrDefault(t => t.Title == title && t.Artist == artist);
            if (track != null)
            {
                return track.ToString();
            }

            return "Track not found!";
        }

        public int GetTracksCount()
        {
            return Tracks.Count;
        }

        public List<Track> GetTracksByGenre(string genre)
        {
            return Tracks
                .Where(t => t.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase))
                .OrderBy(t => t.Duration)
                .ToList();
        }

        public string LibraryReport()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Music Library: {Name}");
            sb.AppendLine($"Tracks capacity: {Capacity}");
            sb.AppendLine($"Number of tracks added: {Tracks.Count}");
            sb.AppendLine("Tracks:");

            foreach (var track in Tracks.OrderByDescending(t => t.Duration))
            {
                sb.AppendLine($"-{track}");
            }

            return sb.ToString().TrimEnd();
        }

    }
}
