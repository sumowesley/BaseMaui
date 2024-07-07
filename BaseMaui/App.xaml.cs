using Microsoft.Maui.Controls;
using Nalu;
using BaseMaui.Models;

namespace BaseMaui
{
    public partial class App : Application
    {
        public App(INavigationService navigationService)
        {
            InitializeComponent();

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Definitions.SyncFusionID);

            MainPage = new AppShell(navigationService);
        }
    }
}
