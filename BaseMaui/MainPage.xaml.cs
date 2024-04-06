using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Core.Platform;

namespace BaseMaui
{
    public partial class MainPage : ContentPage
    {
        //int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        // protected override void OnNavigatedTo(NavigatedToEventArgs args)
        // {
        //     base.OnNavigatedTo(args);
        //     CommunityToolkit.Maui.Core.Platform.StatusBar.SetColor(Color.FromArgb("#F64747"));
        //     CommunityToolkit.Maui.Core.Platform.StatusBar.SetStyle(StatusBarStyle.DarkContent);
            
        // }

        private void OnComplete(object sender, EventArgs e)
        {
            Entry entry = (Entry)sender;
            entry.Unfocus();
        }

    }

}
