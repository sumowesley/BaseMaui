using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Nalu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMaui
{
    public partial class TwoPageViewModel : ObservableObject
    {
        readonly INavigationService _navigationService;
        public TwoPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        [RelayCommand]
        public async Task PopPage()
        {
            await _navigationService.GoToAsync(Navigation.Relative().Pop());
        }
    }
}
