using CommunityToolkit.Mvvm.Input;

namespace BaseMaui {
    public partial class ScreenTwoPageViewModel : BaseViewModel {
        public ScreenTwoPageViewModel() {
        }

        [RelayCommand]
        public async Task GoBack() 
        {
            await Shell.Current.GoToAsync("..",true);
        }
    }

}