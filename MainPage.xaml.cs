using CommunityToolkit.Maui.Sample;
using CommunityToolkit.Maui.Views;
using dotNetMauiPopupSample.Views;

namespace dotNetMauiPopupSample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
    }

    async void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
    {
        try
        {
           await Navigation.PushAsync(new WelcomePage());
		}
		catch(Exception ex)
        {

        }
	}

   
}


