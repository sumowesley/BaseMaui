

namespace BaseMaui
{
    public partial class ScreenTwoPage : ContentPage
    {
        public ScreenTwoPage(ScreenTwoPageViewModel viewModel)
        {
            BindingContext=viewModel;
            InitializeComponent();
        }


    }
}