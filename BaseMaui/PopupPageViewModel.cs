using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nalu;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BaseMaui
{
    public partial class PopupPageViewModel : ObservableObject
    {
        readonly INavigationService _navigationService;

        public PopupPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        [RelayCommand]
        public async Task ClosePopup()
        {
            await _navigationService.GoToAsync(Navigation.Relative().Pop());
        }
    }
}
