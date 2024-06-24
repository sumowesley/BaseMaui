namespace BaseMaui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

                Routing.RegisterRoute("ScreenOnePage", typeof(ScreenOnePage));
                //Routing.RegisterRoute(AlternateRoute2, typeof(ItemDetailsPage));
        }
    }
}
