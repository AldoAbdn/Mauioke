using Mauioke.Dto;

namespace Mauioke.ViewModel
{
    public class KaraokeViewModel : ViewModel
    {
        private SongDto songDto;

        public string DisplayTitle => $"{songDto.Title} - {songDto.Artist}";

        public string Lyrics => "TEST LYRICS"; // Placeholder for actual lyrics loading logic

        public string ImagePath => songDto.ImagePath;

        public KaraokeViewModel(SongDto songDto)
        {
            this.songDto = songDto;
        }

        public void Play()
        {

        }

        public void Pause()
        {

        }

        public void Restart()
        {

        }

        internal SongDto SongDto => songDto;
    }
}
