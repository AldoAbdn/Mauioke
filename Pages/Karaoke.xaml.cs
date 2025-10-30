using Mauioke.Dto;
using Mauioke.ViewModel;

namespace Mauioke.Pages;

public partial class Karaoke : ContentPage
{
	public Karaoke(SongDto songDto)
	{
		InitializeComponent();
		BindingContext = new KaraokeViewModel(songDto);
    }
}