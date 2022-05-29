# .NET MAUI Community Toolkit Popup

The .NET MAU Community Toolkit is a collection of common elements for mobile development with .Net MAUI that people tend to replicate across multiple apps. It simplifies and demonstrates common developer tasks when building apps with Xamarin.Forms.

# Build Status
If you like to live dangerously, you can use our nightly feed to try out the latest and greatest.


# Installation
The Toolkit is available via NuGet, and should be installed into all of your projects (shared and individual platforms):

Browse with the NuGet manager in your IDE to install them or run this command:

Install-Package CommunityToolkit.Maui -Version 1.0.0

Note that the C# Markup Extensions are in a separate package, install that with:

Install-Package CommunityToolkit.CommunityToolkit.Markup

# Getting Started
After installation, start using the features you're after.

In order to use the .NET MAUI Community Toolkit you need to call the extension method in your MauiProgram.cs file as follows:

using CommunityToolkit.Maui;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		
		// Initialise the toolkit
		builder.UseMauiApp<App>().UseMauiCommunityToolkit();

		// the rest of your logic...
	}
}

# XAML usage
In order to make use of the toolkit within XAML you can use this namespace:

xmlns:toolkit="http://schemas.microsoft.com/dotnet/2022/maui/toolkit"


