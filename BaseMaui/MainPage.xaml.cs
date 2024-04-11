using System.Diagnostics;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Core.Platform;

namespace BaseMaui
{
    public partial class MainPage : ContentPage
    {
        //int count = 0;
        readonly MainPageViewModel VM;

        public MainPage(MainPageViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = VM = viewModel;
        }

        // protected override void OnNavigatedTo(NavigatedToEventArgs args)
        // {
        //     base.OnNavigatedTo(args);
        //     CommunityToolkit.Maui.Core.Platform.StatusBar.SetColor(Color.FromArgb("#F64747"));
        //     CommunityToolkit.Maui.Core.Platform.StatusBar.SetStyle(StatusBarStyle.DarkContent);
            
        // }

        private void OnComplete(object sender, EventArgs e)
        {
            Entry entry = (Entry)sender;
            entry.Unfocus();
        }

        private void GetPosition(object sender, TappedEventArgs e)
        {   
            Point pos1 = GetAbsolutePosition(ContentArea);
            Point pos2 = GetAbsolutePosition(VATStatusPageFooter);

            // Check if the views overlap in the y coordinates
            var overlap = (pos1.Y < pos2.Y + VATStatusPageFooter.Frame.Height) && (pos1.Y + ContentArea.Frame.Height > pos2.Y);
            Debug.WriteLine(overlap ? "Overlaps" : "Doesn't Overlap");

            if (overlap) {
                VATStatusScrollView.ZIndex = 2;
                ButtonRow.IsVisible = true;
                VATStatusPageFooter.Opacity = 0;
            }
            else
            {
                VATStatusScrollView.ZIndex = 1;
                ButtonRow.IsVisible = false;
                VATStatusPageFooter.Opacity = 1;
            }
        }

        public Point GetAbsolutePosition(View view)
        {
            double x = view.Frame.X;
            double y = view.Frame.Y;

            var parent = view.Parent;
            while (parent is View parentView)
            {
                x += parentView.Frame.X;
                y += parentView.Frame.Y;
                parent = parentView.Parent;
            }

            return new Point(x, y);
        }

    }

}
