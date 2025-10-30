using Mauioke.Dto;
using Mauioke.ViewModel;

namespace Mauioke.Components;

public partial class SongPicker : ContentView
{
    public SongPicker()
	{
        InitializeComponent();
        BindingContext = new SongPickerViewModel(new List<SongDto>()
        {
            new SongDto(1, "Song A", "Artist A", "path/to/songA.mp3", "path/to/lyricsA.lrc", "path/to/imageA.jpg"),
            new SongDto(2, "Song B", "Artist B", "path/to/songB.mp3", "path/to/lyricsB.lrc", "path/to/imageB.jpg"),
            new SongDto(3, "Song C", "Artist C", "path/to/songC.mp3", "path/to/lyricsC.lrc", "path/to/imageC.jpg"),
            new SongDto(4, "Song D", "Artist D", "path/to/songD.mp3", "path/to/lyricsD.lrc", "path/to/imageD.jpg"),
        });
    }
}