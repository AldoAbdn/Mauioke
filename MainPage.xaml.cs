using Mauioke.Pages;

namespace Mauioke
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void AddSong(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddSong());
        }
    }
}
