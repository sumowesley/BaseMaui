namespace BaseMaui;
using Syncfusion.Maui.Popup;

public partial class PopupPage : SfPopup
{
	public PopupPage(PopupPageViewModel viewmodel)
	{
		InitializeComponent();
		BindingContext = viewmodel;
	}
}