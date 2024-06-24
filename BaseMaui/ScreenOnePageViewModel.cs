using CommunityToolkit.Mvvm.Input;

namespace BaseMaui {
    public partial class ScreenOnePageViewModel : BaseViewModel {
        public ScreenOnePageViewModel() {
        }

        [RelayCommand]
        public async Task GoBack() 
        {
            await Shell.Current.GoToAsync("..",true);
        }
    }

}