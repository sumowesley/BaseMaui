using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls.Xaml.Internals;
using Nalu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMaui
{
    public partial class MainPageViewModel : ObservableObject
    {
        readonly INavigationService _navigationService;

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }


        [RelayCommand]
        public async Task NextPage()
        {
            // await Task.Yield();
            await _navigationService.GoToAsync(Navigation.Relative().Push<TwoPage>());
        }


        [RelayCommand]
        public async Task ShowPopup()
        {
            await Task.Yield();
            // await Task.Yield();
            //await _navigationService.GoToAsync(Navigation.Relative().Push<PopupPage>());
            PopupPageViewModel popupPageViewModel = new();
            PopupPage popupPage = new(popupPageViewModel);
            await popupPage.ShowAsync();
        }

    }
}
