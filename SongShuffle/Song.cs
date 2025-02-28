namespace SongShuffle
{
    class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public bool HasPlayed { get; set; } = false;
        public Song(string title, string artist, string album, string genre, int year)
        {
            Title = title;
            Artist = artist;
            Album = album;
            Genre = genre;
            Year = year;
            HasPlayed = false;
        }

        public Song() { }

        public override string ToString()
        {
            return $"{Title} by {Artist} from {Album} ({Year})";
        }
    }
}
