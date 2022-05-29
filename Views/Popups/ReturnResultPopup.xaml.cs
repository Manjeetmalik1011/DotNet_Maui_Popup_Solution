
using CommunityToolkit.Maui.Views;

namespace CommunityToolkit.Maui.Sample;

public partial class ReturnResultPopup : Popup
{
	public ReturnResultPopup()
	{
		InitializeComponent();
	}

	void Button_Clicked(object? sender, EventArgs e) => Close("Close button tapped");
}