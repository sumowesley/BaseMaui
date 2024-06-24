

namespace BaseMaui
{
    public partial class ScreenOnePage : ContentPage
    {
        public ScreenOnePage(ScreenOnePageViewModel viewModel)
        {
            BindingContext=viewModel;
            InitializeComponent();
        }


    }
}