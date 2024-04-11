using Nalu;

namespace BaseMaui
{
    public partial class AppShell : NaluShell
    {
        public AppShell(INavigationService navigationService) : base(navigationService, typeof(MainPage))
        {
            InitializeComponent();
        }
    }
}
