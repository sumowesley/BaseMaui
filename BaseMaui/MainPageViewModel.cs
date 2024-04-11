using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMaui
{
    public partial class MainPageViewModel : ObservableObject
    {

        public MainPageViewModel()
        {
        
        }


        [RelayCommand]
        public async Task NextPage()
        {
            await Task.Yield();
        }

    }
}
