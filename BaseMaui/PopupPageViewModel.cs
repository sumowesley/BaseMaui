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
        [ObservableProperty]
        public bool isOpen = true;

        public PopupPageViewModel()
        {

        }

        [RelayCommand]
        public async Task ClosePopup()
        {
            await Task.Yield();
            IsOpen= false;
        }
    }
}
