using Mauioke.Dto;
using System.Collections.ObjectModel;

namespace Mauioke.ViewModel
{
    public class SongPickerViewModel : ViewModel
    {
        public ObservableCollection<SongCardViewModel> Songs { get; private set; }
        public SongPickerViewModel(IEnumerable<SongDto> songs)
        {
            Songs = new ObservableCollection<SongCardViewModel>(
                songs.Select(song => new SongCardViewModel(song))
            );
        }
    }
}
