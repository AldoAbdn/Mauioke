using Mauioke.Dto;

namespace Mauioke.ViewModel
{
    public class SongCardViewModel : ViewModel
    {
        private SongDto song;

        public string DisplayTitle => $"{song.Title} - {song.Artist}";
        public string ImagePath => song.ImagePath;

        public SongCardViewModel(SongDto song) {
            this.song = song;
        }
    }
}
