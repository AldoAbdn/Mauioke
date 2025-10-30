namespace Mauioke.Dto
{
    public class SongDto
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Artist { get; private set; }
        public string FilePath { get; private set; }
        public string LyricsPath { get; private set; }
        public string ImagePath { get; private set; }

        public SongDto(int id, string title, string artist, string filePath, string lyricsPath, string imagePath)
        {
            Id = id;
            Title = title;
            Artist = artist;
            FilePath = filePath;
            LyricsPath = lyricsPath;
            ImagePath = imagePath;
        }
    }
}
